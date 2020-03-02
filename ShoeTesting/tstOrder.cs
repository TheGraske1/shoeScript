using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class ShoeTesting
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
            Assert.AreEqual(AnOrder.orderID, TestData);
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
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 orderID = 1;
            Found = AnOrder.Find(orderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNotFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TestData = 12;
            Found = AnOrder.Find(TestData);
            if (AnOrder.TestData != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            Found = anOrder.Find(orderID);
            if(anOrder.dateOrdered != Convert.ToDateTime("16/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if(anOrder.customerID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.staffID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.staffID != 10.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.deliveryAddress != "Test address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.deliveryAddress != "Test address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaidFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.paid != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}
