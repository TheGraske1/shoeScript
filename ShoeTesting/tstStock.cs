using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        { 
            //create an instance
            clsStock AProduct = new clsStock();
            //test is exists
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void LimitedEditionPropertyOK()
        {
            clsStock AProduct = new clsStock();
            Boolean TestData = true;
            AProduct.LimitedEdition = TestData;
            Assert.AreEqual(AProduct.LimitedEdition, TestData);
        }

        [TestMethod]
        public void BackInStockDatePropertyOK()
        {
            clsStock AProduct = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AProduct.BackInStockDate = TestData;
            Assert.AreEqual(AProduct.BackInStockDate, TestData);
        }
        [TestMethod]
        public void QuantityAvailablePropertyOK()
        {
            clsStock AProduct = new clsStock();
            int TestData = 1;
            AProduct.QuantityAvailable = TestData;
            Assert.AreEqual(AProduct.QuantityAvailable, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AProduct = new clsStock();
            double TestData = 19.99;
            AProduct.Price = TestData;
            Assert.AreEqual(AProduct.Price, TestData);
        }
        [TestMethod]
        public void StyleNamePropertyOK()
        {
            clsStock AProduct = new clsStock();
            String TestData = "Any Style";
            AProduct.StyleName = TestData;
            Assert.AreEqual(AProduct.StyleName, TestData);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsStock Aproduct = new clsStock();
            int TestData = 1;
            Aproduct.ProductId = 1;
            Assert.AreEqual(Aproduct.ProductId, TestData);
        }




    }
}
