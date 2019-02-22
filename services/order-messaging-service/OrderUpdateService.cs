using System;
using MessagingExampleApp.Domain;
using MessagingExampleApp.Interfaces;

namespace MessagingExampleApp.Services
{
    public class OrderUpdateService: ICommandService<Order>
    {
        private readonly IQueueService<Order> _queue;

        public OrderUpdateService(IQueueService<Order> queue)
        {
            this._queue = queue;
        }

        public bool CreateItem(Order order)
        {
            throw new NotImplementedException("Create tests first");
        }
    }
}
