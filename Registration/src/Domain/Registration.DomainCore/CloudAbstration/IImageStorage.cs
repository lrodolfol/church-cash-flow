namespace Registration.DomainCore.CloudAbstration;

public interface IImageStorage
{
    HashSet<string> AllowImageTypes { get; }
    string ImageType { get; set; }
    string StorageName { get; set; }
    string ImagePath { get; set; }
    string FileName { get; set; }
    string Base64Image { get; set; }
    
    public Task<bool> SaveImage();
}