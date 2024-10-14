using New_Project;
using System;
using System.Collections;
using System.Collections.Generic;

namespace New_Project
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

            Console.WriteLine("Orders:");
            foreach (Order order in orders)
            {
                if (order.PhoneNumber.ToString().StartsWith("375"))
                {
                    order.DisplayInformation();
                }
            }

            Console.WriteLine("Orders starting with 'Whysk' and price <= 20:");
            foreach (Order order in orders)
            {
                if (order.Price <= Price && order.ProductName.StartsWith("Whysk"))
                {
                    order.DisplayInformation();
                }
            }

            Console.WriteLine("NewOrders:");
            foreach (Order order in newOrders)
            {
                Console.WriteLine($"Order Type: {order.GetType().Name}");
                order.DisplayInformation();
                Console.WriteLine();
            }

            List<Order> orderList = new List<Order>(orders);

            orderList.Sort();
            Console.WriteLine("Sorted by Phone Number:");
            foreach (var order in orderList)
            {
                order.DisplayInformation();
                Console.WriteLine();
            }

            orderList.Sort((o1, o2) => o1.ProductName.CompareTo(o2.ProductName));
            Console.WriteLine("Sorted by Product Name:");
            foreach (var order in orderList)
            {
                order.DisplayInformation();
                Console.WriteLine();
            }

            orderList.Sort((o1, o2) => o1.Price.CompareTo(o2.Price));
            Console.WriteLine("Sorted by Price:");
            foreach (var order in orderList)
            {
                order.DisplayInformation();
                Console.WriteLine();
            }

            orderList.Sort((o1, o2) => o1.DeliveryAddress.CompareTo(o2.DeliveryAddress));
            Console.WriteLine("Sorted by Delivery Address:");
            foreach (var order in orderList)
            {
                order.DisplayInformation();
                Console.WriteLine();
            }

            Console.WriteLine("Most frequent product:");
            Dictionary<string, int> productFrequency = new Dictionary<string, int>();

            foreach (var order in orderList)
            {
                if (productFrequency.ContainsKey(order.ProductName))
                {
                    productFrequency[order.ProductName]++;
                }
                else
                {
                    productFrequency[order.ProductName] = 1;
                }
            }

            string mostFrequentProduct = null;
            int maxCount = 0;

            foreach (var entry in productFrequency)
            {
                if (entry.Value > maxCount)
                {
                    mostFrequentProduct = entry.Key;
                    maxCount = entry.Value;
                }
            }

            if (mostFrequentProduct != null)
            {
                Console.WriteLine($"Product Name: {mostFrequentProduct}, Count: {maxCount}");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}
