using System.Threading.Tasks;

namespace MessagingExampleApp.Interfaces
{
    public interface IQueueService<T>
    {
        bool Send(IMessage<T> message);
    }
}