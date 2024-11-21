using System;
using System.Text;
namespace Task5
{
    
    public class AutoDelivery : IDelivery
    {
        const int min = 30;
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} will be delivered by car");
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(min);
        }
    }
}
