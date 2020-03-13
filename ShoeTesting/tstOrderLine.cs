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
        [TestMethod]
        public void OrderIDMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "0";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "2";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMAxMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "999998";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "999999";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "500000";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1000000";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1500000";
            string product = "4";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "0";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "2";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMaxMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "999998";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "999999";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1000000";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "500000";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1500000";
            string quantity = "15";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "0";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "2";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "49";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "50";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "51";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "25";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "100";
            string selection = "Nike Air style";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "a";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "aa";
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMaxMinOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            selection = selection.PadRight(49, 'a');
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            selection = selection.PadRight(50, 'a');
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            selection = selection.PadRight(51, 'a');
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            selection = selection.PadRight(25, 'a');
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SelectionDescriptionExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string orderID = "1";
            string product = "1";
            string quantity = "1";
            string selection = "";
            selection = selection.PadRight(100, 'a');
            Error = AnOrderLine.Valid(orderID, product, quantity, selection);
            Assert.AreNotEqual(Error, "");
        }
    }
}
