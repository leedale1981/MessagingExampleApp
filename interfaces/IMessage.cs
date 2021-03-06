namespace MessagingExampleApp.Interfaces
{
    public enum MessageType
    {
        Create,
        Update
    }
    public interface IMessage<T>
    {
        MessageType Type { get; }
        T Item { get; }
    }
}