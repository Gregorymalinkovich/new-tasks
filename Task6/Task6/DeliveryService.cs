using New_Project;
using NUnit.Framework;
using System;
using System.IO;
using Task6;

namespace New_Project.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Order_ShouldThrowException_WhenInvalidPhoneNumber()
        {
            Assert.Throws<ArgumentException>(() => new Order("Laptop", 1234567, 500, "Minsk"));
        }

        [Test]
        public void Order_ShouldThrowException_WhenPriceOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Order("Laptop", 3751234567890, 1200, "Minsk"));
        }

        [Test]
        public void DiscountOrder_ShouldThrowException_WhenDiscountOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new DiscountOrder("Laptop", 3751234567890, 500, "Minsk", 120));
        }

        [Test]
        public void VIPOrder_ShouldThrowException_WhenGiftIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new VIPOrder("Laptop", 3751234567890, 500, "Minsk", null));
        }
    }

    [TestFixture]
    public class DeliveryServiceTests
    {
        [Test]
        public void DeliveryService_ShouldAddCourier_Successfully()
        {
            var service = new DeliveryService();
            var courier = new AutoDelivery();
            service.AddCourier(courier);
            Assert.DoesNotThrow(() => service.DeliverOrder(new Order("Laptop", 3751234567890, 500, "Minsk")));
        }

        [Test]
        public void DeliveryService_ShouldSelectFastestDeliveryMethod()
        {
            var service = new DeliveryService();
            service.AddCourier(new MotoDelivery());
            service.AddCourier(new DroneDelivery());

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                service.DeliverOrder(new Order("Laptop", 3751234567890, 500, "Minsk"));
                Assert.IsTrue(sw.ToString().ToLower().Contains("drone"));
            }
        }
    }
}
