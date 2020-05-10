using System;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ShoeTesting
{
    [TestClass]
    public class tstStock
    {
        string StyleName = "testStyleName";
        string BackInStockDate = DateTime.Now.Date.ToString();
        string Price = "49.99";
        string QuantityAvailable = "10";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMinLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMin()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "a";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMinPlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "aa";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StylenameMaxLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            StyleName = StyleName.PadRight(49, 'a');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMax()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            StyleName = StyleName.PadRight(50, 'a');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMaxPlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            StyleName = StyleName.PadRight(51, 'a');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMid()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            StyleName = StyleName.PadRight(25, 'a');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StylenameMaxExtreme()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string StyleName = "";
            StyleName = StyleName.PadRight(500, 'a');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateExtremeMin()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateMinLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateMin()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateMinPlusOneDay()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateMinPlusOneMonth()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMonths(1);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateMinPlusOneYear()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BackInStockDateExtremeMax()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string BackInStockDate = TestDate.ToString();
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BackInStockDateInvalidData()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string BackInStockDate = "This is not valid date!";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "1";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "10";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "999999.99";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "9999999.99";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "99999.99";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "99.99";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExterm()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(250, '9');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityAvailableMinLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMin()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "1";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailablePlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "10";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityAvailableMaxLessOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "999";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMax()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "9999";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMaxPlusOne()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "10000";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMid()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "499";
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityAvailableExtrem()
        {
            clsStock AProduct = new clsStock();
            String Error = "";
            string QuantityAvailable = "";
            QuantityAvailable = QuantityAvailable.PadRight(500, '9');
            Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
            Assert.AreNotEqual(Error, "");
        }















    }
}
