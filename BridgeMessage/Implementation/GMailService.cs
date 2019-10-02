using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BridgeMessage.Implementation
{
    public class GMailService : IMessageService
    {
        public void SendMessage(string message, string to)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("jvicius@gmail.com", ConfigurationManager.AppSettings["emailpass"]),
                EnableSsl = true
            };

            try
            {
                client.Send("jvicius@gmail.com", to, "c# GMailService", message);
            }
            catch (Exception e)
            {
                
            }
            

            Console.WriteLine("Sending using gmail");
        }
    }
}
