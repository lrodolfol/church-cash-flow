namespace Registration.DomainCore.CloudAbstration;

public interface IGetUrlPreSigned
{
    HashSet<string> AllowImageTypes { get; }
    string StorageName { get; set; }
    
    public Task<string> GetPreSignedUrlBucketImage(string path);
}