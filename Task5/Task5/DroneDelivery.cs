using System;
using System.Text;
namespace Task5
{
    public class DroneDelivery : IDelivery
    {
        const int min = 15;
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} will be delivered by drone");
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(min);
        }
    }
}
