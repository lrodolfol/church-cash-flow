using Amazon.S3;
using Amazon.S3.Model;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CloudServices.AWS;

public class AWSBucketS3
{
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
        if (!AllowImageTypes.Any() || String.IsNullOrEmpty(StorageName) || 
            String.IsNullOrEmpty(FileName) || String.IsNullOrEmpty(ImageType) || 
            String.IsNullOrEmpty(Base64Image) || String.IsNullOrEmpty(ImagePath))
            return Task.FromResult(false);

        if (!CheckValues())
            return Task.FromResult(false);

        try
        {
            byte[] imageBytes = Convert.FromBase64String(Base64Image);

            AmazonS3Client s3Client = new AmazonS3Client();

            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = StorageName,
                Key = $"image/{ImagePath}/{FileName}.{ImageType}",
                InputStream = new MemoryStream(imageBytes),
                ContentType = "image/ImageType"
            };

            Task<PutObjectResponse> response = s3Client.PutObjectAsync(request);
        }
        catch
        {
            return Task.FromResult(false);
        }

        return Task.FromResult(true);
    }

    private bool CheckValues()
    {
        if (!AllowImageTypes.Contains(ImageType))
            return false;
        

        Base64Image = Base64Image.Replace("data:image/jpeg;base64,", "");
        FileName = Regex.Replace(FileName, @"\s", "_");

        return true;
    }
}