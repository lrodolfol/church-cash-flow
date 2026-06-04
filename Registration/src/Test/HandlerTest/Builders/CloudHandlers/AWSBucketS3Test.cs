using Registration.DomainCore.CloudAbstration;
using System.ComponentModel.DataAnnotations;

namespace HandlersTest.Builders.CloudHandlers;
internal class AWSBucketS3Test : IGetUrlPreSigned
{
    public HashSet<string> AllowImageTypes { get; } = new HashSet<string>(new[] { "jpg", "jpeg" });
    [Required]
    public string StorageName { get; set; } = null!;

    public Task<string> GetPreSignedUrlBucketImage(string path)
    {
        return Task.FromResult(string.Empty);
    }
}
