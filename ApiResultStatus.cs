using Microsoft.OpenApi.Models;

namespace WebApplication1
{
    public class ApiResultStatus
    {
        public ApiResultStatus()
        {
            Error = new ApiError();
            LoggingMessage = new List<ApiLoggingItem>();
        }

        public List<ApiLoggingItem> LoggingMessage { get; set; }

        public ApiError Error { get; set; }
    }
}