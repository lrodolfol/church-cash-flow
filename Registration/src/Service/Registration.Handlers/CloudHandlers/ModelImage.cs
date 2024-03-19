using CloudServices.AWS;
using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.CloudAbstration;
using Serilog;

namespace Registration.Handlers.CloudHandlers;

public class ModelImage
{
    private readonly ILogger _logger;
    private readonly string _modelPath;
    private readonly string _fileName;

    public ModelImage(string modelPath, string fileName, ILogger logger)
    {
        _logger = logger;
        _modelPath = modelPath;
        _fileName = fileName;
    }

    public async Task SaveImageStoreAsync(string? base64Image)
    {
        if (string.IsNullOrEmpty(base64Image))
        {
            _logger.Information("There are no image to save");
            return;
        }

        IImageStorage storage = new AWSBucketS3(_logger);
        storage.Base64Image = base64Image;
        storage.StorageName = CentralPackages.ConfigurationBridge.AwsCloudConfiguration.BucketS3.Images.Name;
        storage.FileName = _fileName;
        storage.ImageType = CentralPackages.ConfigurationBridge.AwsCloudConfiguration.BucketS3.Images.ImageTypePattern;
        storage.ImagePath = _modelPath!;

        await storage.SaveImage();
    }
}