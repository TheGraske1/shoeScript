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
        public void InstanceOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ProductId = 1;
            TestItem.StyleName = "Test Style name";
            TestItem.BackInStockDate = DateTime.Now.Date;
            TestItem.Price = 9.99;
            TestItem.QuantityAvailable = 100;
            TestItem.LimitedEdition = true;
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
            TestProduct.StyleName = "Test Style name";
            TestProduct.BackInStockDate = DateTime.Now.Date;
            TestProduct.Price = 9.99;
            TestProduct.QuantityAvailable = 100;
            TestProduct.LimitedEdition = true;
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
            TestItem.StyleName = "Test Style name";
            TestItem.BackInStockDate = DateTime.Now.Date;
            TestItem.Price = 9.99;
            TestItem.QuantityAvailable = 100;
            TestItem.LimitedEdition = true;
            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;
            Assert.AreEqual(AllProducts.Count, TestList.Count);

        }

        /* [TestMethod]
        public void CountPropartyOK()
        {
            clsStockCollection ALLProducts = new clsStockCollection();
            Int32 SomeCount = 2;
            ALLProducts.Count = SomeCount;
            Assert.AreEqual(ALLProducts.Count, SomeCount);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Assert.AreEqual(AllProducts.Count, 2);
        }*/
    }
}
