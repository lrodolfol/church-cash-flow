using Serilog.Events;
using Serilog.Formatting;
using System.Text;

namespace Registration.DependencyInjection;

public class CustomizedLogs : ITextFormatter
{
    public void Format(LogEvent logEvent, TextWriter output)
    {
        output.Write(RenderLogEvent(logEvent));
    }

    public string RenderLogEvent(LogEvent logevent)
    {
        var builder = new StringBuilder();

        builder.AppendLine($"level: [{logevent.Level}");
        builder.AppendLine($"Message: [{logevent.RenderMessage()}");

        if(logevent.Exception == null)
            return builder.ToString();

        builder.AppendLine($"Exception: [{logevent.Exception}]");

        if(logevent.Properties != null)
        {
            var detail = new StringBuilder();

            foreach (var item in logevent.Properties)
                detail.Append($"{item.Key} : {item.Value}");

            builder.Append($"Exception details: {detail}");
        }

        builder.AppendLine($"ExceptionDetail: [{logevent.Exception}]");

        return builder.ToString();
    }
}
