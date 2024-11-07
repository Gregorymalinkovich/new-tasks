using New_Project;
using System;

namespace Task7
{
    public class OnFootDelivery : IDelivery
    {
        const int hours = 2;

        public bool DeliverOrder(Order order)
        {
            return true;
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromHours(hours);
        }
    }
}
