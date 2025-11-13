using Microsoft.OpenApi.Models;

namespace WebApplication1
{
    public class ApiResultStatus
    {
        public ApiResultStatus()
        {
            Error = new APIError();
            LoggingMessage = new List<APILoggingItem>();
        }

        public List<APILoggingItem> LoggingMessage { get; set; } = new List<APILoggingItem>();

        public APIError Error { get; set; }
    }
}