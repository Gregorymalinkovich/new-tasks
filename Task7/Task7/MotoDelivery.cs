using New_Project;
using System;

namespace Task7
{
    public class MotoDelivery : IDelivery
    {
        const int min = 45;

        public bool DeliverOrder(Order order)
        {
            return true;
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(min);
        }
    }
}
