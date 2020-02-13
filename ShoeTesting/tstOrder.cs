using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void PaidPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Paid = TestData;
            Assert.AreEqual(AnOrder.Paid, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.dateOrdered = TestData;
            Assert.AreEqual(AnOrder.dateOrdered, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Some address";
            AnOrder.deliveryAddress = TestData;
            Assert.AreEqual(AnOrder.deliveryAddress, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.orderID = TestData;
            Assert.Equals(AnOrder.orderID, TestData);
        }
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1234;
            AnOrder.customerID = TestData;
            Assert.Equals(AnOrder.customerID, TestData);
        }
        public void StaffIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 123;
            AnOrder.staffID = TestData;
            Assert.Equals(AnOrder.staffID, TestData);
        }
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            double TestData = 5.62;
            AnOrder.totalPrice = TestData;
            Assert.Equals(AnOrder.totalPrice, TestData);
        }

    }
}
