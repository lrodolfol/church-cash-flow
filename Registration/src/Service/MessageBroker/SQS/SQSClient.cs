using Amazon.SQS;
using Amazon.SQS.Model;
using Registration.CentralPackages;

namespace MessageBroker.SQS;
public class SQSClient<T> : IMessageBrokerClient where T : SQSBaseEvent
{
    private readonly T ModelMessage;

    public SQSClient(T modelMessage)
    {
        ModelMessage = modelMessage;
    }

    public async Task Publish()
    {
        var client = new AmazonSQSClient(
            Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"), 
            Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY"),
            Amazon.RegionEndpoint.GetBySystemName(ConfigurationBridge.AwsCloudConfiguration.Region)
            );

        GetQueueUrlResponse getQueueUrl = client.GetQueueUrlAsync(ConfigurationBridge.AwsCloudConfiguration.Sqs.monthlyClosingQueueName).Result;
        if ((int)getQueueUrl.HttpStatusCode >= 300)
            throw new HttpRequestException($"Error getting queue URL: {getQueueUrl.HttpStatusCode}");

        var message = new SendMessageRequest
        {
            QueueUrl = getQueueUrl.QueueUrl,
            MessageBody = ModelMessage.BodyMessage
        };

        SendMessageResponse response = await client.SendMessageAsync(message);
    }
}
