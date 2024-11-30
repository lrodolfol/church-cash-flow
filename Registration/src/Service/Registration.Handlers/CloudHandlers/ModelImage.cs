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
    private readonly IImageStorage _storage;

    public ModelImage(string modelPath, string fileName, ILogger logger, IImageStorage storage)
    {
        _modelPath = modelPath;
        _fileName = fileName;
        _logger = logger;
        _storage = storage;
    }

    public async Task SaveImageStoreAsync(string? base64Image)
    {
        if (string.IsNullOrEmpty(base64Image))
        {
            _logger.Information("There are no image to save");
            return;
        }

        _storage.Base64Image = base64Image;
        _storage.StorageName = CentralPackages.ConfigurationBridge.AwsCloudConfiguration.BucketS3.Images.Name;
        _storage.FileName = _fileName;
        _storage.ImageType = CentralPackages.ConfigurationBridge.AwsCloudConfiguration.BucketS3.Images.ImageTypePattern;
        _storage.ImagePath = _modelPath!;

        await _storage.SaveImage();
    }
}