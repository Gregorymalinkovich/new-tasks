using System;
namespace Task5
{
    public class DeliveryService
    {
        private List<IDelivery> _couriers;

        public DeliveryService()
        {
            _couriers = new List<IDelivery>();
        }

        public void AddCourier(IDelivery courier)
        {
            _couriers.Add(courier);
            Console.WriteLine("A new courier has been added to the delivery service");
        }

        public void DeliverOrder(Order order)
        {
            if (_couriers.Count == 0)
            {
                Console.WriteLine("No available couriers");
                return;
            }

            var bestCourier = _couriers.OrderBy(c => c.ExpectedDeliveryTime(order)).First();
            bestCourier.DeliverOrder(order);
        }
    }
}
