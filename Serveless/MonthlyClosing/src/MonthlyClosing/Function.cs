using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Amazon.S3;
using Amazon.S3.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MonthlyClosing;
public class Function
{
    IAmazonS3 S3Client { get; set; }
    string BuckerName { get; set; }

    public Function(IAmazonS3 s3Client)
    {
        this.S3Client = s3Client;
    }
    public Function()
    {
        S3Client = new AmazonS3Client();

        if (string.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "PROD", StringComparison.Ordinal))
            BuckerName = "churchmanager-prod";
        else if (string.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "UAT", StringComparison.Ordinal))
            BuckerName = "churchmanager-uat";
        else
            BuckerName = "churchmanager-dev";
    }

    public async Task FunctionHandler(SQSEvent evnt, ILambdaContext context)
    {
        foreach (SQSEvent.SQSMessage? message in evnt.Records)
        {
            await ProcessMessageAsync(message, context);
        }
    }

    private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
    {
        context.Logger.LogInformation($"Mensagem para processamento: {message.Body}");

        if (message.EventSource == "aws:sqs" && message.EventSourceArn.Contains("monthly-closing"))
        {
            await PostMonthClosedAsync(message, context);
        }
        else if (message.EventSource == "aws:sqs" && message.EventSourceArn.Contains("monthly-opening"))
        {
            await DeleteMonthClosedAsyn(message, context);
        }
    }

    private async Task PostMonthClosedAsync(SQSEvent.SQSMessage message, ILambdaContext context)
    {
        try
        {
            var body = JsonSerializer.Deserialize<Model>(message.Body);
            if (body == null)
            {
                context.Logger.LogError("Error to deserialize message body");
                throw new Exception("Error to deserialize message body");
            }

            await CreatePdfSendToS3Async(body, context);
        }
        catch (Exception ex)
        {
            context.Logger.LogError($"Error to process message body. Error: {ex.Message}");
        }

        await Task.CompletedTask;
    }
    private async Task CreatePdfSendToS3Async(Model cashFlowRequest, ILambdaContext context)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        var document = new MonthClosedRequest(cashFlowRequest);
        var file = document.GeneratePdf();
        string key = $"month-work/{cashFlowRequest.ChurchId}.{cashFlowRequest.Competence}.pdf";

        PutObjectRequest request = new PutObjectRequest
        {
            BucketName = BuckerName,
            Key = key,
            InputStream = new MemoryStream(file),
            ContentType = "application/pdf"
        };

        PutObjectResponse response = await S3Client.PutObjectAsync(request);
        if (response.HttpStatusCode != HttpStatusCode.OK)
            context.Logger.LogError($"Fail to send file to S3 - key: {key}");
        else
            context.Logger.LogInformation("File sent to S3");
    }

    private async Task DeleteMonthClosedAsyn(SQSEvent.SQSMessage message, ILambdaContext context)
    {
        try
        {
            var body = JsonSerializer.Deserialize<MonthOpenedRequest>(message.Body);
            if (body == null)
            {
                context.Logger.LogError("Error to deserialize message body");
                throw new Exception("Error to deserialize message body");
            }

            await DeletePdfFromS3Async(body, context);
        }
        catch (Exception ex)
        {
            context.Logger.LogError($"Error to process message body. Error: {ex.Message}");
        }

        await Task.CompletedTask;
    }

    private async Task DeletePdfFromS3Async(MonthOpenedRequest body, ILambdaContext context)
    {
        string key = $"month-work/{body.ChurchId}.{body.Competence}.pdf";
        DeleteObjectRequest request = new DeleteObjectRequest
        {
            BucketName = BuckerName,
            Key = key
        };

        DeleteObjectResponse response = await S3Client.DeleteObjectAsync(request);
        if(response.HttpStatusCode != HttpStatusCode.NoContent)
            context.Logger.LogError($"Fail to delete file from S3 - key: {key}-{response.HttpStatusCode}");
        else
            context.Logger.LogInformation("File deleted from S3");  
    }
}