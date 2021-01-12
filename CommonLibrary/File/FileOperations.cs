using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class  FileOperations
    {
        /// <summary>
        /// its use to upload the file
        /// </summary>
        /// <param name="UploadFilePath"></param>
        /// <returns></returns>
        public static  FileUpload upload(List<string> UploadFilePaths)
        {
            FileUpload fileUpload = new FileUpload();
            
            foreach(var UploadFilePath in UploadFilePaths)
            {
                if (string.IsNullOrEmpty(UploadFilePath))
                {
                    fileUpload.Status = StatusFlag.Failure;
                    fileUpload.Message = "File Path is Empty";
                    fileUpload.FileName = Path.GetFileName(UploadFilePath);

                    return fileUpload;
                }
                else
                {
                    var folderName = Path.Combine("Resources", "Images");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                    if (UploadFilePath.Length > 0)
                    {
                        var fileName = Path.GetFileName(UploadFilePath);
                        var fullPath = Path.Combine(pathToSave, fileName);
                        //var dbPath = Path.Combine(folderName, fileName);

                        FileStream f = new FileStream(UploadFilePath, FileMode.OpenOrCreate);

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            f.CopyTo(stream);

                        }
                        fileUpload.Status = StatusFlag.Success;
                        fileUpload.Message = "File Uploaded";
                        fileUpload.FileName = fileName;
                    }

                    
                }
               
            }
            return fileUpload;


        }
        /// <summary>
        /// its use to download the file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static async Task<FileDownloadBase64String> Download(string filename)
        {

            FileDownloadBase64String fileDownload = new FileDownloadBase64String();

            if (string.IsNullOrEmpty(filename))
            {
                fileDownload.Status = StatusFlag.Failure;
                fileDownload.Message = "File Path is Empty";
                fileDownload.FileName = Path.GetFileName(filename);                 
            }
            else
            { 
                //
                //Pending for default path location conformations.
                //
                var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "Resources\\Images", filename);
                byte[] bytes;
                var memory = new MemoryStream();
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                    bytes = memory.ToArray();
                    fileDownload.Status = StatusFlag.Success;
                    fileDownload.Message = "File Downloaded";
                    fileDownload.FileName = filename;
                    fileDownload.FileContentsAsBase64 = Convert.ToBase64String(bytes);
                }
                             

            }

            return fileDownload;

        }
    }
    
}
