namespace Opgavesæt4.Counter
{
    public class RequestLogger
    {
        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static readonly string LogFileName = "request_log.txt";
        private static readonly string LogFilePath = Path.Combine(DesktopPath, LogFileName);

        public static void LogRequest(string requestPath)
        {
            string logMessage = $"{DateTime.Now}: Request for {requestPath}";
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);

            int totalRequests = CalculateTotalRequests(requestPath);
            string totalRequestsMessage = $"Total requests for {requestPath}: {totalRequests}";
            File.AppendAllText(LogFilePath, totalRequestsMessage + Environment.NewLine);

            File.AppendAllText(LogFilePath, Environment.NewLine);
        }

        private static int CalculateTotalRequests(string requestPath)
        {
            if (requestPath.Contains("/Songs"))
            {
                int TotalRequests = SongRequestCounter.GetCounter(requestPath);
                return TotalRequests;
            }

            else if (requestPath.Contains("/Albums"))
            {
                int TotalRequests = AlbumRequestCounter.GetCounter(requestPath);
                return TotalRequests;
            }

            return 0;
        }
    }
}
