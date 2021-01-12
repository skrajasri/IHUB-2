using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public enum StatusFlag { Success, Failure }
    public class FileUpload
    {
        public StatusFlag Status { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }
    }

    public class FileDownloadBase64String
    {
        public StatusFlag Status { get; set; }
        public string Message { get; set; }

        public string FileName { get; set; }
        public string FileContentsAsBase64 { get; set; }

        public static implicit operator Task<object>(FileDownloadBase64String v)
        {
            throw new NotImplementedException();
        }
    }

}
