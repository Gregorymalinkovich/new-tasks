using New_Project;
using System;


namespace Task6
{
    public class OnFootDelivery : IDelivery
    {
        const int hours = 2;
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} will be delivered by foot courier");
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromHours(hours);
        }
    }
}