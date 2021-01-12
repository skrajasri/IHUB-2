using CommonLibrary.LogMethod;
using CommonLibrary;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary.Mail
{
    public class GMailServices : IGMailServices
    {
        /// <summary>
        /// Common GMail Send Method
        /// Before use this method.Change the "Less secure app access" to ON Gmail settings.
        /// https://myaccount.google.com/u/0/lesssecureapps?pli=1&pageId=none&rapt=AEjHL4NPA9Q0oksG89rxNMqpvGFr6DclxzS-3gDvz4fjw_JzaTrxgbdWwwoxE_0vqyDrDecLRh1i8iVoCMVFItTS_YwsXHK_2Q
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="html"></param>
        public void SendMail(string to, string subject, string html)
        {
            Log log = new Log();
            LogModel logModel = new LogModel();

            try
            {                             
                // Create the message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(CommonLibraryConfig.GMailID));
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                email.Body = new TextPart(TextFormat.Html) { Text = html };

                // send email
                var smtp = new SmtpClient();
                smtp.Connect(CommonLibraryConfig.GMailSmtp, CommonLibraryConfig.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(CommonLibraryConfig.GMailID, CommonLibraryConfig.Password);
                smtp.Send(email);
                smtp.Disconnect(true);

                // Log for success Mail Send..                
                logModel.LogType = LogTypes.Information;
                logModel.Message = to + ":Mail Send Success";               
                log.LogWrite(logModel);
            }
            catch(Exception ex)
            {
                // Log for success Mail Send..            
                logModel.LogType = LogTypes.Error;
                logModel.Message = to + " : "+ ex.Message;
                log.LogWrite(logModel);
            }
        }
    }
}
