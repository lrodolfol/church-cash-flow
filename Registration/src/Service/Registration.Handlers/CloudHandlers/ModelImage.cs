using Registration.DomainCore.CloudAbstration;
using Serilog;

namespace Registration.Handlers.CloudHandlers;

public class ModelImage
{
    private readonly IGetUrlPreSigned _storage;

    public ModelImage(IGetUrlPreSigned storage)
    {
        _storage = storage;
    }

    public async Task<string> GetPreSignedUrlBucketImage(string path)
    {
        _storage.StorageName = CentralPackages.ConfigurationBridge.AwsCloudConfiguration.BucketS3.Images.Name;

        return await _storage.GetPreSignedUrlBucketImage(path);
    }
}