using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BridgeMessage.Implementation
{
    public class TwilioService : IMessageService
    {
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        public void SendMessage(string message, string to)
        {
            TwilioClient.Init(accountSid, authToken);

            try
            {
                var sms = MessageResource.Create(
                    body: message,
                    from: new Twilio.Types.PhoneNumber("+4491091867"),
                    to: new Twilio.Types.PhoneNumber($"+{to}")
                );
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            

            Console.WriteLine("Sending using twilio");
        }
    }
}
