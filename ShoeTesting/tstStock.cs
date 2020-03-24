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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.ProductId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStyleNameFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.StyleName != "TestStyleName")
            {
                OK = false;
            
            }
            Assert.IsTrue(OK);

        }
        
        [TestMethod]
        public void TestQuantityAvailableFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.QuantityAvailable != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.Price != 49.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
 
        }

        [TestMethod]
        public void TestLimitedEditionFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.LimitedEdition != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
       public void TestBackInStockDateFound()
        {
            clsStock AProduct = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = AProduct.Find(ProductId);
            if (AProduct.BackInStockDate != Convert.ToDateTime("17/05/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        public void ValidMethodOK()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

    }
}
