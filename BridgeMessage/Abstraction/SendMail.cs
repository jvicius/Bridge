namespace BridgeMessage.Abstraction
{
    public class SendMail : SendDataMessage
    {
        public override void Send(string message, string to)
        {
            BridgeMessageService.SendMessage(message, to);
        }
    }
}