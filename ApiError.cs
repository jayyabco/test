using System.Text.Json.Serialization;

namespace WebApplication1
{
    public class ApiError
    {
        public ApiError()
        {
        }

        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        [JsonIgnore]
        public string StackTrace { get; set; } = string.Empty;

        [JsonPropertyName("stackTrace")]
        public string StackTracePublic => string.Empty;
    }
}