using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7; 

namespace TestDroneDelivery
{
    [TestClass]
    public class DroneDeliveryTests
    {
        [TestMethod]
        public void TestDeliverOrder_ReturnsTrue()
        {
            var droneDelivery = new DroneDelivery();
            var order = new Order();
            var result = droneDelivery.DeliverOrder(order);
            Assert.IsTrue(result, "DroneDelivery should return true when DeliverOrder is called");
        }

        [TestMethod]
        public void TestExpectedDeliveryTime_ReturnsCorrectTime()
        {
            var droneDelivery = new DroneDelivery();
            var order = new Order();
            var expectedTime = TimeSpan.FromMinutes(15);
            var actualTime = droneDelivery.ExpectedDeliveryTime(order);
            Assert.AreEqual(expectedTime, actualTime, "The expected delivery time for DroneDelivery should be 15 minutes");
        }
    }
}
