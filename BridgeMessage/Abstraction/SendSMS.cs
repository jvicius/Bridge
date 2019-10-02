namespace BridgeMessage.Abstraction
{
    public class SendSMS : SendDataMessage
    {
        public override void Send(string message, string to)
        {
            BridgeMessageService.SendMessage(message, to);
        }
    }
}