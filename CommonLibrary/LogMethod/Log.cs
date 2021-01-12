using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonLibrary.LogMethod
{
    public class Log
    {
        private static string logFormat = string.Empty;
        private static string logPath = string.Empty;

        /// <summary>
        /// write the log
        /// </summary>
        /// <param name="logMessage"></param>
        
        public  void LogWrite(LogModel logMessage)
        {
            logPath = Path.Combine(
                           Directory.GetCurrentDirectory(), "LogMessage");

            logFormat = DateTime.Now.ToLongDateString().ToString() + " - " +
                DateTime.Now.ToLongTimeString().ToString() + " ==> ";

            try
            {
                string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                
                using (StreamWriter writer = File.AppendText(logPath +"\\" + logFile))
                {
                   writer.WriteLine(logFormat + logMessage.LogType  +" : "+logMessage.Message );
                }

            }
            catch (Exception ex)
            {
                
            }
        }
    }
    
}
