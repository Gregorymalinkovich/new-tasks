using New_Project;
using System;

namespace Task7
{
    public class DiscountOrder : Order
    {
        private float _discount;
        public float Discount
        {
            get => _discount;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value), "Discount must be between 0 and 100.");
                _discount = value;
            }
        }

        public DiscountOrder(string productName, long phoneNumber, float price, string deliveryAddress, float discount)
            : base(productName, phoneNumber, price, deliveryAddress)
        {
            Discount = discount;
        }

        public override bool DisplayInformation()
        {
            return true;
        }
    }
}
