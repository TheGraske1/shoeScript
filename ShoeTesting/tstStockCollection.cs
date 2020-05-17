using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoeTesting
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstantOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.LimitedEdition = true;
            TestItem.StyleName = "Test Style Name";
            TestItem.Price = 49.99;
            TestItem.QuantityAvailable = 10;
            TestItem.BackInStockDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void ThisProductPropartyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestProduct = new clsStock();
            TestProduct.ProductId = 1;
            TestProduct.LimitedEdition = true;
            TestProduct.StyleName = "Test Style Name";
            TestProduct.Price = 49.99;
            TestProduct.QuantityAvailable = 10;
            TestProduct.BackInStockDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.LimitedEdition = true;
            TestItem.StyleName = "Test Style Name";
            TestItem.Price = 49.99;
            TestItem.QuantityAvailable = 10;
            TestItem.BackInStockDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductId = 1;
            TestItem.LimitedEdition = true;
            TestItem.StyleName = "Test Style Name";
            TestItem.Price = 49.99;
            TestItem.QuantityAvailable = 10;
            TestItem.BackInStockDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();
            TestItem.ProductId = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ProductId = 1;
            TestItem.LimitedEdition = true;
            TestItem.StyleName = "Test Style Name";
            TestItem.Price = 49.99;
            TestItem.QuantityAvailable = 10;
            TestItem.BackInStockDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();
            TestItem.ProductId = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            AllProducts.Delete();
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.LimitedEdition = true;
            TestItem.StyleName = "Test Style Name";
            TestItem.Price = 49.99;
            TestItem.QuantityAvailable = 10;
            TestItem.BackInStockDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();
            TestItem.LimitedEdition = false;
            TestItem.StyleName = "Updated Test Style Name";
            TestItem.Price = 59.99;
            TestItem.QuantityAvailable = 150;
            TestItem.BackInStockDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            AllProducts.Update();
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void ReportBtStyleNameMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStockCollection FilteredProducts = new clsStockCollection();
            FilteredProducts.ReportByStyleName("");
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByStyleNameNoneFound()
        {
            clsStockCollection FilteredProducts = new clsStockCollection();
            FilteredProducts.ReportByStyleName("none found");
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportedByStyleNameTestDataFound()
        {
            clsStockCollection FilteredProducts = new clsStockCollection();
            Boolean OK = true;
            FilteredProducts.ReportByStyleName("Test Style Name");
            if (FilteredProducts.Count == 2)
            {
                if(FilteredProducts.ProductList[0].ProductId != 5)
                {
                    OK = false;
                }
                if (FilteredProducts.ProductList[1].ProductId != 13)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
        }
    }
}
