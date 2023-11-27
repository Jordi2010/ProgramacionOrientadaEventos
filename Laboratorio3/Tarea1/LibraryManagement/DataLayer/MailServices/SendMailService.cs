using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.MailServices
{
    public class SendMailService : MasterMailService
    {
        public SendMailService() 
        {
            Host = "sandbox.smtp.mailtrap.io";
            Port = 2525;
            Username = "311e963ff691eb";
            Password = "e22c40c66d392c";
            Sender = "LibraryKotaku@gmail.com";
            Ssl = false;
            InitializeSmtpClient();
        }
    }
}
