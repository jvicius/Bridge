using System;
using System.Configuration;
using System.Net.Mail;

namespace BridgeMessage.Implementation
{
    public class YMailService : IMessageService
    {
        public void SendMessage(string message, string to)
        {
            var client = new SmtpClient
            {
                Host = "smtp.mail.yahoo.com",
                Port = 465,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential
                    ("eq9lce1@yahoo.com.mx", ConfigurationManager.AppSettings["emailpass"]),
                EnableSsl = true
            };

            try
            {
                client.Send("jvicius@gmail.com", to, "c# GMailService", message);
            }
            catch (Exception e)
            {
                
            }

            Console.WriteLine("Sending using yahoo mail");
        }
    }
}
