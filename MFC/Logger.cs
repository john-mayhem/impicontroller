using System;
using System.IO;

namespace MFC
{
    public class Logger
    {
        private readonly string logFilePath;

        public Logger()
        {
            // Specify the subfolder name where the log files will be stored
            var logFolderName = "log";
            // Combine the base directory with the subfolder name to get the full path
            var logFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, logFolderName);

            // Check if the directory exists
            if (!Directory.Exists(logFolderPath))
            {
                // If it doesn't exist, create it
                Directory.CreateDirectory(logFolderPath);
            }

            // Create the log file name with a timestamp
            var logFileName = $"log_{DateTime.Now:yyyyMMdd_HHmmss}.log";
            // Combine the log folder path with the log file name
            logFilePath = Path.Combine(logFolderPath, logFileName);
            // Ensure the log file is created when the logger is instantiated
            File.Create(logFilePath).Close();
        }

        public void Log(string message)
        {
            try
            {
                // Append a log entry with a timestamp
                File.AppendAllText(logFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during logging
                // In a real-world application, you might want to handle this more gracefully
                Console.WriteLine("Error writing to log file: " + ex.Message);
            }
        }
    }
}