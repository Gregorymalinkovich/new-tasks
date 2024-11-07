using New_Project;
using System;
using System.Linq;

namespace Task7
{
    public class DeliveryService
    {
        private List<IDelivery> _couriers;

        public DeliveryService()
        {
            _couriers = new List<IDelivery>();
        }

        public bool AddCourier(IDelivery courier)
        {
            _couriers.Add(courier);
            return true;
        }

        public bool DeliverOrder(Order order)
        {
            if (_couriers.Count == 0)
            {
                return false;
            }

            var bestCourier = _couriers.OrderBy(c => c.ExpectedDeliveryTime(order)).First();
            return bestCourier.DeliverOrder(order);
        }
    }
}
