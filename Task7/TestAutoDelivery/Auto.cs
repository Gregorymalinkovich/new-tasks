using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7;
using System;

namespace TestAutoDelivery
{
    [TestClass]
    public class AutoDeliveryTests
    {
        [TestMethod]
        public void TestDeliverOrder_ReturnsTrue()
        {
            var autoDelivery = new AutoDelivery();
            var order = new Order();
            var result = autoDelivery.DeliverOrder(order);
            Assert.IsTrue(result, "AutoDelivery should return true");
        }

        [TestMethod]
        public void TestExpectedDeliveryTime_ReturnsCorrectTime()
        {
            var autoDelivery = new AutoDelivery();
            var order = new Order();
            var expectedTime = TimeSpan.FromMinutes(30);
            var actualTime = autoDelivery.ExpectedDeliveryTime(order);
            Assert.AreEqual(expectedTime, actualTime, "The expected delivery time should be 30 minutes");
        }
    }
}
