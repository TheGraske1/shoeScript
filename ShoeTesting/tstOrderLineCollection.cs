using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ShoeTesting
{   [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);

        }
        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.orderID = 3;
            TestItem.orderLineID = 1;
            TestItem.productID = 4;
            TestItem.quantity = 2;
            TestItem.selectionDescription = "Nike Ultra";
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);


        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderLineCollection AllOrderLiness = new clsOrderLineCollection();
            Int32 SomeCount = 2;
            AllOrderLiness.Count = SomeCount;
            Assert.AreEqual(AllOrderLiness.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.orderID = 3;
            TestOrderLine.orderLineID = 1;
            TestOrderLine.productID = 4;
            TestOrderLine.quantity = 2;
            TestOrderLine.selectionDescription = "Nike Ultra";
            AllOrderLines.ThisOrderLine = TestOrderLine;
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);
        }

            
         /*REMOVED AS PER TUTORIAL!!
          *
          * public void ListAndCountOK()
         {
             clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
             List<clsOrderLine> TestList = new List<clsOrderLine>();
             clsOrderLine TestItem = new clsOrderLine();
             TestItem.orderID = 3;
            TestItem.orderLineID = 1;
            TestItem.productID = 4;
            TestItem.quantity = 2;
            TestItem.selectionDescription = "Nike Ultra";
             TestList.Add(TestItem);
             AllOrderLines.OrderLineList = TestList;
             Assert.AreEqual(AllOrderLines.Count, TestList.Count);
         }
        
          [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.AreEqual(AllOrderLines.Count, 2);

        }
        */

    }
}
