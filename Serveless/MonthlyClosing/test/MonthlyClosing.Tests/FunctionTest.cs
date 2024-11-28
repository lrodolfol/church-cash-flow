using Xunit;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.SQSEvents;

namespace MonthlyClosing.Tests;

public class FunctionTest
{
    [Fact]
    public async Task TestSQSEventLambdaFunction()
    {
        var sqsEvent = new SQSEvent
        {
            Records = new List<SQSEvent.SQSMessage>
            {
                new SQSEvent.SQSMessage
                {
                    Body = "{\"ChurchId\":1,\"ChurchName\":\"CEOS\\u00E3oLouren\\u00E7o\",\"Competence\":\"2024-08-01\",\"FlowJsonFile\":[{\"Competence\":\"11/2024\",\"Day\":\"2024-08-19T00:00:00\",\"PreviousBalance\":0,\"CurrentBalance\":-102.00,\"Title\":null,\"Description\":\"Saidadecaixa1\",\"AmountInputOperation\":0.00,\"AmountOutPutOperation\":102.00,\"TotalOperation\":0},{\"Competence\":\"2023/03\",\"Day\":\"2024-08-24T00:00:00\",\"PreviousBalance\":-102.00,\"CurrentBalance\":-89.20,\"Title\":null,\"Description\":\"ofertadoirmao/irma\",\"AmountInputOperation\":12.80,\"AmountOutPutOperation\":0.00,\"TotalOperation\":0},{\"Competence\":\"2023/02\",\"Day\":\"2024-08-19T00:00:00\",\"PreviousBalance\":-89.20,\"CurrentBalance\":-33.30,\"Title\":null,\"Description\":\"ofertadoirmao/irma\",\"AmountInputOperation\":55.90,\"AmountOutPutOperation\":0.00,\"TotalOperation\":0},{\"Competence\":\"2023/05\",\"Day\":\"2024-08-04T00:00:00\",\"PreviousBalance\":-33.30,\"CurrentBalance\":-20.50,\"Title\":null,\"Description\":\"ofertadoirmao/irma\",\"AmountInputOperation\":12.80,\"AmountOutPutOperation\":0.00,\"TotalOperation\":0},{\"Competence\":\"04/2023\",\"Day\":\"2024-08-29T00:00:00\",\"PreviousBalance\":-20.50,\"CurrentBalance\":36.10,\"Title\":null,\"Description\":\"Primiciasdoirmao/irma\",\"AmountInputOperation\":56.60,\"AmountOutPutOperation\":0.00,\"TotalOperation\":0},{\"Competence\":\"02/2023\",\"Day\":\"2024-08-14T00:00:00\",\"PreviousBalance\":36.10,\"CurrentBalance\":192.70,\"Title\":null,\"Description\":\"Primiciasdoirmao/irma\",\"AmountInputOperation\":156.60,\"AmountOutPutOperation\":0.00,\"TotalOperation\":0}],\"OcurredOn\":\"2024-11-28T00:16:03.673645Z\"}"
                }
            }
        };

        var logger = new TestLambdaLogger();
        var context = new TestLambdaContext
        {
            Logger = logger
        };

        var function = new Function();
        await function.FunctionHandler(sqsEvent, context);

        Assert.Equal(1, 1);
    }
}