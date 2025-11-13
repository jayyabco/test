namespace WebApplication1
{
    public class APILoggingItem
    {
        public APILoggingItem()
        {
        }

        public APILoggingItem(string msg, string pStatus, string pTrace)
        {
            Message = msg;
            Status = pStatus;
            Trace = pTrace;
        }

        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Trace { get; set; } = string.Empty;
    }
}