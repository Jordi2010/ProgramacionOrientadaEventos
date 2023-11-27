using MailKit.Net.Smtp;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.MailServices
{
    public abstract class MasterMailService
    {
        protected SmtpClient smtpClient { get; set; }
        protected string Host { get; set; }
        protected string Sender { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void InitializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Connect(Host, Port, Ssl);
            smtpClient.Authenticate(Username, Password);
        
        }
        
        public void SendMail(string subject, string body, string destinationEmail, string username)
        {
            var message = new MimeMessage();
            
                try
            {
                message.From.Add(new MailboxAddress("biblioteca", Sender));
                message.To.Add(new MailboxAddress(username,destinationEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };
                smtpClient.Send(message);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                smtpClient.Disconnect(true);
                message.Dispose();
            }        
            
        }


    }
}
