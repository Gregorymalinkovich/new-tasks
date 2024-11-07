using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7;

namespace OnFootDeliveryTest
{
    [TestClass]
    public class OnFootDeliveryTests
    {
        [TestMethod]
        public void TestDeliverOrder_ReturnsTrue()
        {
            var onFootDelivery = new OnFootDelivery();
            var order = new Order();
            var result = onFootDelivery.DeliverOrder(order);
            Assert.IsTrue(result, "OnFootDelivery should return true when DeliverOrder is called.");
        }

        [TestMethod]
        public void TestExpectedDeliveryTime_ReturnsCorrectTime()
        {
            var onFootDelivery = new OnFootDelivery();
            var order = new Order();
            var expectedTime = TimeSpan.FromHours(2);
            var actualTime = onFootDelivery.ExpectedDeliveryTime(order);
            Assert.AreEqual(expectedTime, actualTime, "The expected delivery time for OnFootDelivery should be 2 hours.");
        }
    }
}
