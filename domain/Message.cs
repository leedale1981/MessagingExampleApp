using MessagingExampleApp.Interfaces;

namespace MessagingExampleApp.Domain
{
    public class Message<T> : IMessage<T>
    {
        public MessageType Type { get; private set; }
        public T Item { get; private set; }

        public Message(MessageType type, T item)
        {
            this.Type = type;
            this.Item = item;
        }
    }
}