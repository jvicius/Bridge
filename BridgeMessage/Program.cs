using System;
using BridgeMessage.Abstraction;
using BridgeMessage.Implementation;

namespace BridgeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            SendDataMessage serviceMessage;

            serviceMessage = new SendMail();
            serviceMessage.BridgeMessageService = new GMailService();
            serviceMessage.Send("Message from Bridge Test","jvicius@gmail.com");

            serviceMessage = new SendSMS();
            serviceMessage.BridgeMessageService = new TwilioService();
            serviceMessage.Send("Message from Bridge Test", "4491091867");

            Console.ReadKey();
        }
    }
}
