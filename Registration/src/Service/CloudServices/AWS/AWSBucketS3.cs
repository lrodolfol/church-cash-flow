using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;
using Registration.DomainCore.CloudAbstration;
using Serilog;
using System.ComponentModel.DataAnnotations;

namespace CloudServices.AWS;

public class AWSBucketS3 : IGetUrlPreSigned
{
    private readonly ILogger _logger;

    public AWSBucketS3(ILogger logger)
    {
        _logger = logger;
    }

    public HashSet<string> AllowImageTypes { get; } = new HashSet<string>(new[] { "jpg", "jpeg" });
    [Required]
    public string StorageName { get; set; } = null!;

    public async Task<string> GetPreSignedUrlBucketImage(string path)
    {
        var s3Client = GetS3Client();

        var request = new GetPreSignedUrlRequest
        {
            BucketName = StorageName,
            Key = $"images/{path}/{path}_{Guid.NewGuid().ToString().ToUpper().Substring(0, 6)}.jpg",
            Verb = HttpVerb.PUT,
            Expires = DateTime.UtcNow.AddMinutes(5),
            ContentType = "image/jpeg"
        };

        string url = await s3Client.GetPreSignedURLAsync(request);

        return url;
    }

    private static AmazonS3Client GetS3Client()
    {
        if (string.Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "DEVELOPMENT", StringComparison.OrdinalIgnoreCase))
            return new AmazonS3Client();

        return new AmazonS3Client(
            Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"),
            Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY")
            );
    }
}