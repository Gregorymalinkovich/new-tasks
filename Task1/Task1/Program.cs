using System;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int maxPrice = 20;
            const string targetProductName = "Whys";
            const string targetPhonePrefix = "375";

            Order[] orders = new Order[]
            {
                new Order("Whysk", 3751234567890, 15f, "Minsk"),
                new Order("Laptop", 3759876543210, 999f, "Grodno"),
                new Order("Fridge", 1234567890123, 900f, "Gomel")
            };

           
            foreach (var order in orders)
            {
                order.DisplayInformation();
                
            }

           
            foreach (var order in orders)
            {
                if (order.PhoneNumber.ToString().StartsWith(targetPhonePrefix))
                {
                    order.DisplayInformation();
                    
                }
            }

            foreach (var order in orders)
            {
                if (order.Price <= maxPrice && order.ProductName.StartsWith(targetProductName))
                {
                    order.DisplayInformation();

                }
            }
        }
    }
}
