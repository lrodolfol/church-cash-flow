using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Amazon.S3;
using Amazon.S3.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
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

            await CreatePDF(body);
        }
        catch (Exception ex)
        {
            context.Logger.LogError("Error to process message body");
        }



        // TODO: Do interesting work based on the new message
        await Task.CompletedTask;
    }

    private async Task CreatePDF(Model cashFlowRequest)
    {
        QuestPDF.Settings.License = LicenseType.Community;
        
        var document = new InvoiceDocument(cashFlowRequest);

        //PutObjectRequest request = new PutObjectRequest
        //{
        //    BucketName = "church-manager-uat",
        //    Key = $"month-work/{FileName}.{ImageType}",
        //    InputStream = new MemoryStream(imageBytes),
        //    ContentType = "image/ImageType"
        //};

        try
        {
            document.GeneratePdfAndShow();
        }catch(Exception ex)
        {
            throw;
        }
        
    }
}