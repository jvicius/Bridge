using BridgeMessage.Implementation;

namespace BridgeMessage.Abstraction
{
    public abstract class SendDataMessage
    {
        public IMessageService BridgeMessageService;

        public abstract void Send(string message, string to);
    }
}