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
            Assert.AreEqual(anOrderLine.orderLineID, TestData);

        }
        [TestMethod]
        public void orderIDPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 1234;
            anOrderLine.orderID = TestData;
            Assert.AreEqual(anOrderLine.orderID, TestData);

        }
        [TestMethod]
        public void productIDPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 6234;
            anOrderLine.productID = TestData;
            Assert.AreEqual(anOrderLine.productID, TestData);

        }
        [TestMethod]
        public void quantityPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            int TestData = 2;
            anOrderLine.quantity = TestData;
            Assert.AreEqual(anOrderLine.quantity, TestData);

        }
        
        [TestMethod]
        public void selectionDescriptionPropertyOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();
            String TestData = "This is the selection";
            anOrderLine.selectionDescription = TestData;
            Assert.AreEqual(anOrderLine.selectionDescription, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 TestData = 4;
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
            if (AnOrderLine.orderLineID != 4)
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
            if (AnOrderLine.orderID != 12)
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
            if (AnOrderLine.productID != 1)
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            string error = "";
            string orderID = "2";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(error, "");
        }
        


    }
}
