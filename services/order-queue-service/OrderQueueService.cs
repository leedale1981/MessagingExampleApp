using System;
using MessagingExampleApp.Domain;
using MessagingExampleApp.Interfaces;
using Microsoft.Azure.ServiceBus;

namespace MessagingExampleApp.Services
{
    public class OrderQueueService: IQueueService<Order>
    {
        public bool Send(IMessage<Order> message)
        {

        }

        public async Task ProcessMessages(Message message, CancellationToken token)
        {
            
        }
    }
}
