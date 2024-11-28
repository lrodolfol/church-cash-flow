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
    public Function(IAmazonS3 s3Client)
    {
        this.S3Client = s3Client;
    }
    public Function()
    {
        S3Client = new AmazonS3Client();
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
        var JsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        try
        {
            var body = JsonSerializer.Deserialize<Model>(message.Body);
            if(body == null)
            {
                context.Logger.LogError("Error to deserialize message body");
                return;
            }

            await CreatePDF(body, context);
        }
        catch (Exception ex)
        {
            context.Logger.LogError("Error to process message body");
        }

        await Task.CompletedTask;
    }

    private async Task CreatePDF(Model cashFlowRequest, ILambdaContext context)
    {
        QuestPDF.Settings.License = LicenseType.Community;
        
        var document = new InvoiceDocument(cashFlowRequest);
        var file = document.GeneratePdf();

        PutObjectRequest request = new PutObjectRequest
        {
            BucketName = "churchmanager-dev",
            Key = $"month-work/{cashFlowRequest.ChurchId}.{cashFlowRequest.Competence}.pdf",
            InputStream = new MemoryStream(file),
            ContentType = "application/pdf"
        };

        PutObjectResponse response = await S3Client.PutObjectAsync(request);
        if (response.HttpStatusCode != HttpStatusCode.OK)
            context.Logger.LogError("Fail to send file to S3");
        else
            context.Logger.LogInformation("File sent to S3");    
    }
}