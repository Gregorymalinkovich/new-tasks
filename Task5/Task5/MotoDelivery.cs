using System;
using System.Text;
namespace Task5
{
    public class MotoDelivery : IDelivery
    {
        const int min = 45;
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} will be delivered by motorcycle");
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(min);
        }
    }
}
