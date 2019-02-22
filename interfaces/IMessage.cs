namespace MessagingExampleApp.Interfaces
{
    public enum MessageType
    {
        Create,
        Update
    }
    public interface IMessage<T>
    {
        MessageType Type { get; set; }
        T Item { get; set; }
    }
}