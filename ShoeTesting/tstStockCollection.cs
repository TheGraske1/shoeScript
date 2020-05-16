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

    }
}
