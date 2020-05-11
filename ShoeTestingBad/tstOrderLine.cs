using System;
using ClassLibrary1;
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
            double TestData = 234.23;
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

    }
}
