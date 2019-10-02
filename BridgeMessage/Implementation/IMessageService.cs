namespace BridgeMessage.Implementation
{
    public interface IMessageService
    {
        void SendMessage(string message, string to);
    }
}