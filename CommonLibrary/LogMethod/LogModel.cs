using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary.LogMethod
{
    public enum LogTypes { Information ,Error ,Warning}
    public class LogModel
    {
        public LogTypes LogType { get; set; }  
        public string Message { get; set; }
    }
}
