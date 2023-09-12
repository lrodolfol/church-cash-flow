using CloudServices.AWS;
using Microsoft.Extensions.Configuration;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.CloudAbstration;
using Serilog;

namespace Registration.Handlers.CloudHandlers;

public class MembersImage
{
    private IConfiguration _configuration;
    private readonly ILogger _logger;

    public MembersImage(ILogger logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task SaveImageStoreAsync(Member member, string? base64Image)
    {
        if (string.IsNullOrEmpty(base64Image))
        {
            _logger.Information("There are no image to save");
            return;
        }

        IImageStorage storage = new AWSBucketS3(_logger);
        storage.Base64Image = base64Image;
        storage.StorageName = _configuration.GetValue<string>("cloudServices:aws:bucketS3:images:Name")!;
        storage.FileName = $"{member.Code}";
        storage.ImageType = _configuration.GetValue<string>("cloudServices:aws:bucketS3:images:imageTypePattern")!;
        storage.ImagePath = _configuration.GetValue<string>("cloudServices:aws:bucketS3:images:membersPath")!;

        await storage.SaveImage();
    }
}