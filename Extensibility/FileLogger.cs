using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
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
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("{0}: {1}" , messageType, message);
            }
        }
    }
}
