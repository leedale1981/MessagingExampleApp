namespace MessagingExampleApp.Interfaces
{
    public interface IQueueService
    {
        bool Send(IMessage message);
    }
}