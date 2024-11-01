using System;
namespace New_Project
{
    public interface IDelivery
    {
        void DeliverOrder(Order order);
        TimeSpan ExpectedDeliveryTime(Order order);
    }
}
