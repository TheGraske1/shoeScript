using System;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void IstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void orderLineIDPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 234;
            anOrderLine.orderLineID = TestData;
            Assert.Equals(anOrderLine.orderLineID, TestData);

        }
        [TestMethod]
        public void orderIDPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 1234;
            anOrderLine.orderID = TestData;
            Assert.Equals(anOrderLine.orderID, TestData);

        }
        [TestMethod]
        public void productIDPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 6234;
            anOrderLine.productID = TestData;
            Assert.Equals(anOrderLine.productID, TestData);

        }
        [TestMethod]
        public void quantityPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 2;
            anOrderLine.quantity = TestData;
            Assert.Equals(anOrderLine.quantity, TestData);

        }
        [TestMethod]
        public void pricePerUnitPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
             float TestData = Convert.ToInt32(234.23);
            anOrderLine.pricePerUnit = TestData;
            Assert.Equals(anOrderLine.pricePerUnit, TestData);

        }
        [TestMethod]
        public void selectionDescriptionPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String TestData = "This is the selection";
            anOrderLine.selectionDescription = TestData;
            Assert.Equals(anOrderLine.selectionDescription, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 TestData = 3;
            Found = AnOrderLine.Find(TestData);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderLineNotFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.orderLineID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.orderID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.productID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.quantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPricePerUnitFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.pricePerUnit != 5.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSelectionDescriptionFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 4;
            Found = AnOrderLine.Find(orderLineID);
            if (AnOrderLine.selectionDescription != "Testing description")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
