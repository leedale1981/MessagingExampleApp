using System;
using NUnit.Framework;
using Moq;
using MessagingExampleApp.Domain;
using MessagingExampleApp.Interfaces;
using MessagingExampleApp.Services;

namespace Tests
{
    [TestFixture]
    public class OrderUpdateService_ShouldSendMessages
    {
        private readonly OrderUpdateService _orderService;

        public OrderUpdateService_ShouldSendMessages()
        {
            this._orderService = new OrderUpdateService(this.CreateMockedQueueService());
        }

        private IQueueService<Order> CreateMockedQueueService()
        {
            var mockQueueService = new Mock<IQueueService<Order>>();
            mockQueueService.Setup(
                q => q.Send(It.IsAny<IMessage<Order>>())
            ).Returns(true);

            return mockQueueService.Object;
        }

        [Test]
        public void Should_Send_Create_Order_Message()
        {
            var order = new Order
            {
                Id = 1,
                Title = "Test Order",
                Description = "Testing create order.",
                DateCreated = DateTime.Now
            };

            var result = this._orderService.CreateItem(order);

            Assert.AreEqual(true, result);
        }
    }
}