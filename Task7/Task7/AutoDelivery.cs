using New_Project;
using System;

namespace Task7
{
    public class AutoDelivery : IDelivery
    {
        const int min = 30;

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
