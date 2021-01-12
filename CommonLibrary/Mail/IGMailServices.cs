using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary.Mail
{
    interface IGMailServices
    {
       void SendMail(string to, string subject, string html);
    }
}
