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
        public void ListAndCountOK()
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
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.selectionDescription = "Nike Air";
            TestItem.orderID = 1;
            TestItem.productID = 1;
            TestItem.quantity = 2;
            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.orderLineID = PrimaryKey;
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.orderLineID = 1;
            TestItem.selectionDescription = "Nike Air";
            TestItem.orderID = 1;
            TestItem.productID = 1;
            TestItem.quantity = 2;
            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.orderLineID = PrimaryKey;
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            AllOrderLines.Delete();
            Boolean Found = AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 1;
            TestItem.orderID = 1;
            TestItem.selectionDescription = "Jordan Air";
            TestItem.productID = 1;
            TestItem.quantity = 4;
            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.orderID = 2;
            TestItem.selectionDescription = "Jordan Air but different";
            TestItem.productID = 2;
            TestItem.quantity = 3;
            AllOrderLines.ThisOrderLine = TestItem;
            AllOrderLines.Update();
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);

        }

        [TestMethod]
        public void ReportBySelectionDescriptionMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            FilteredOrderLines.ReportBySelectionDescription("");
            Assert.AreEqual(AllOrderLines.Count, FilteredOrderLines.Count);
        }

        [TestMethod]
        public void ReportBySelectionDescriptionNoneFound()
        {
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            FilteredOrderLines.ReportBySelectionDescription("xxx xxx");
            Assert.AreEqual(0, FilteredOrderLines.Count);
        }

        [TestMethod]
        public void ReportBySelectionDescriptionTestDataFound()
        {
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            Boolean OK = true;
            FilteredOrderLines.ReportBySelectionDescription("Adidas");
            if(FilteredOrderLines.Count == 3)
            {
                if(FilteredOrderLines.OrderLineList[0].orderLineID != 3)
                {
                    OK = false;
                }
                if(FilteredOrderLines.OrderLineList[1].orderLineID != 13)
                {
                    OK = false;
                }
                if (FilteredOrderLines.OrderLineList[2].orderLineID != 16)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        /*REMOVED AS PER TUTORIAL!!
         *
         * 

         [TestMethod]
       public void TwoRecordsPresent()
       {
           clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
           Assert.AreEqual(AllOrderLines.Count, 2);

       }

        public void CountPropertyOK()
        {
            clsOrderLineCollection AllOrderLiness = new clsOrderLineCollection();
            Int32 SomeCount = 2;
            AllOrderLiness.Count = SomeCount;
            Assert.AreEqual(AllOrderLiness.Count, SomeCount);
        }
       */

    }
}
