using New_Project;

namespace Task7
{
    public interface IDelivery
    {
        bool DeliverOrder(Order order);
        TimeSpan ExpectedDeliveryTime(Order order);
    }
}
