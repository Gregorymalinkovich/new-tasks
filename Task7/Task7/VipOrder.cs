using New_Project;
using System;

namespace Task7
{
    public class VIPOrder : Order
    {
        public string Gift { get; set; }

        public VIPOrder(string productName, long phoneNumber, float price, string deliveryAddress, string gift)
            : base(productName, phoneNumber, price, deliveryAddress)
        {
            Gift = gift ?? throw new ArgumentNullException(nameof(gift), "Gift cannot be null.");
        }

        public override bool DisplayInformation()
        {
            return true;
        }
    }
}
