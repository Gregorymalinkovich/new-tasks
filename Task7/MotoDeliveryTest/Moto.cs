using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7;

namespace MotoDeliveryTest
{
    [TestClass]
    public class MotoDeliveryTests
    {
        [TestMethod]
        public void TestDeliverOrder_ReturnsTrue()
        {
            var motoDelivery = new MotoDelivery();
            var order = new Order();
            var result = motoDelivery.DeliverOrder(order);
            Assert.IsTrue(result, "MotoDelivery should return true when DeliverOrder is called");
        }

        [TestMethod]
        public void TestExpectedDeliveryTime_ReturnsCorrectTime()
        {
            var motoDelivery = new MotoDelivery();
            var order = new Order();
            var expectedTime = TimeSpan.FromMinutes(45);
            var actualTime = motoDelivery.ExpectedDeliveryTime(order);
            Assert.AreEqual(expectedTime, actualTime, "The expected delivery time for MotoDelivery should be 45 minutes");
        }
    }
}
