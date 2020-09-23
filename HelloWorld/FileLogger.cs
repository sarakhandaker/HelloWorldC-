using System.IO;

namespace HelloWorld
{
    public class FileLogger : ILogger
    {
        public FileLogger(string path)
        {
            this._path = path;
        }

        private string _path { get; }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
