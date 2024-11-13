namespace Registration.CentralPackages;
public static class ConfigurationBridge
{
    public static AwsCloud AwsCloudConfiguration { get; set; } = new();

    public class AwsCloud
    {
        public string Accesskey { get; set; } = string.Empty;
        public string Secretkey { get; set; } = string.Empty;
        public string Loggroup { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public BucketS3 BucketS3 { get; set; } = new BucketS3();
        public Sqs Sqs { get; set; } = new Sqs();
    }

    public class BucketS3
    {
        public Images Images { get; set; } = new Images();
    }
    public class Sqs
    {
        public string monthlyClosingQueueName { get; set; } = string.Empty;
    }

    public class Images
    {
        public string Name { get; set; } = string.Empty;
        public string ImageTypePattern { get; set; } = string.Empty;
    }
}
