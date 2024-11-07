using System;

namespace Task7
{
    public class Order : IComparable<Order>
    {
        public string ProductName { get; set; }
        public string DeliveryAddress { get; set; }
        private const int RequiredPhoneLength = 13;
        private const int MaxPrice = 1000;

        private long _phoneNumber;
        public long PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.ToString().Length != RequiredPhoneLength)
                    throw new ArgumentException("Phone number must be exactly 13 digits.");
                _phoneNumber = value;
            }
        }

        private float _price;
        public float Price
        {
            get => _price;
            set
            {
                if (value <= 0 || value > MaxPrice)
                    throw new ArgumentOutOfRangeException(nameof(value), "Price must be > 0 and <= 1000.");
                _price = value;
            }
        }
        public Order()
        {

        }

        public Order(string productName, long phoneNumber, float price, string deliveryAddress)
        {
            ProductName = productName;
            PhoneNumber = phoneNumber;
            Price = price;
            DeliveryAddress = deliveryAddress;
        }

        public virtual bool DisplayInformation()
        {
            return true;
        }

        public int CompareTo(Order other) => other == null ? 1 : PhoneNumber.CompareTo(other.PhoneNumber);
    }
}
