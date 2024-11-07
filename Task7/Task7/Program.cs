using New_Project;
using System;

namespace Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Price = 20;

            MyList<Order> orders = new MyList<Order>();
            orders.AddFirst(new Order("Whysk", 1234567890123, 20f, "Minsk"));
            orders.AddFirst(new Order("LapTop", 3756543210123, 999f, "Grodno"));
            orders.AddFirst(new Order("Fridge", 1112223333123, 990f, "Gomel"));

            MyList<Order> newOrders = new MyList<Order>();
            newOrders.AddFirst(new VIPOrder("Windows", 1234567890123, 20, "Vilnus", "Free pen"));
            newOrders.AddFirst(new DiscountOrder("Mac", 3756543210123, 999, "Riga", 10f));
            newOrders.AddFirst(new OrdinaryOrder("Camera", 1112223333123, 990, "Poznan"));


            DeliveryService deliveryService = new DeliveryService();
            deliveryService.AddCourier(new OnFootDelivery());
            deliveryService.AddCourier(new MotoDelivery());
            deliveryService.AddCourier(new AutoDelivery());
            deliveryService.AddCourier(new DroneDelivery());

            Order newOrder = new Order("Laptop", 3756543210123, 999f, "Minsk");
            deliveryService.DeliverOrder(newOrder);
        }
    }
}
