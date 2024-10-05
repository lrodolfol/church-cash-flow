using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;
using Registration.DomainCore.CloudAbstration;
using Serilog;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CloudServices.AWS;

public class AWSBucketS3 : IImageStorage
{
    private readonly ILogger _logger;
    private string FunctionName = "Save Image Bucket S3";

    public AWSBucketS3(ILogger logger)
    {
        _logger = logger;
    }

    public HashSet<string> AllowImageTypes { get; } = new HashSet<string>(new[] { "jpg", "jpeg" });
    [Required]
    public string StorageName { get; set; } = null!;
    [Required]
    public string FileName { get; set; } = null!;
    [Required]
    public string ImageType { get; set; } = null!;
    [Required]
    public string Base64Image { get; set; } = null!;
    public string? MessageLog { get; set; }
    public string ImagePath { get; set; } = null!;

    public Task<bool> SaveImage()
    {
        AmazonS3Client s3Client = GetS3Client();

        if (!AllowImageTypes.Any() || String.IsNullOrEmpty(StorageName) ||
            String.IsNullOrEmpty(FileName) || String.IsNullOrEmpty(ImageType) ||
            String.IsNullOrEmpty(Base64Image) || String.IsNullOrEmpty(ImagePath))
        {
            _logger.Error("Image not save. Invalid Parameters");
            return Task.FromResult(false);
        }

        if (!CheckValues())
        {
            _logger.Error("Image not save. Invalid Parameters");
            return Task.FromResult(false);
        }

        try
        {
            byte[] imageBytes = Convert.FromBase64String(Base64Image);

            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = StorageName,
                Key = $"image/{ImagePath}/{FileName}.{ImageType}",
                InputStream = new MemoryStream(imageBytes),
                ContentType = "image/ImageType"
            };

            Task<PutObjectResponse> response = s3Client.PutObjectAsync(request);
            response.Wait();
            _logger.Information("Success to save image");
        }
        catch (Exception ex)
        {
            _logger.Error($"{FunctionName} - Error to save the image > {ex.Message}");
            return Task.FromResult(false);
        }

        return Task.FromResult(true);
    }

    private static AmazonS3Client GetS3Client()
    {
        if (string.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "DEVELOPMENT", StringComparison.OrdinalIgnoreCase))
            return new AmazonS3Client();

        return new AmazonS3Client(
            Registration.CentralPackages.ConfigurationBridge.AwsCloudConfiguration.Accesskey,
            Registration.CentralPackages.ConfigurationBridge.AwsCloudConfiguration.Secretkey
            );
    }

    private bool CheckValues()
    {
        bool isPNG = Base64Image.StartsWith("data:image/png;base64,");
        bool isJPEG = Base64Image.StartsWith("data:image/jpeg;base64,");

        if ( (!AllowImageTypes.Contains(ImageType)) || (!isPNG && !isJPEG) )
        {
            _logger.Error($"{FunctionName} - The image is a not valid image");
            return false;
        }

        Base64Image = Base64Image.Replace("data:image/jpeg;base64,", "");
        Base64Image = Base64Image.Replace("data:image/png;base64,", "");
        FileName = Regex.Replace(FileName, @"\s", "_");

        return true;
    }
}