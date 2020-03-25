
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace ShoeTesting
{
   [TestClass]
   public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.paid = true;
            TestItem.orderID = 3;
            TestItem.staffID = 1;
            TestItem.totalPrice = 12.55;
            TestItem.customerID = 2;
            DateTime today = DateTime.Today.Date;
            TestItem.dateOrdered = today;
            TestItem.deliveryAddress = "LE30HH";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);

            
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 2;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.paid = true;
            TestOrder.orderID = 1;
            TestOrder.staffID = 2;
            TestOrder.totalPrice = 12.55;
            TestOrder.customerID = 3;
            TestOrder.dateOrdered = DateTime.Today.Date;
            TestOrder.deliveryAddress = "LE30HH";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.customerID = 1;
            TestItem.dateOrdered = DateTime.Today.Date;
            TestItem.deliveryAddress = "LE30HH";
            TestItem.orderID = 1;
            TestItem.paid = true;
            TestItem.staffID = 1;
            TestItem.totalPrice = 12.50;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.orderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.customerID = 1;
            TestItem.dateOrdered = DateTime.Today.Date;
            TestItem.deliveryAddress = "LE30HH";
            TestItem.orderID = 1;
            TestItem.paid = true;
            TestItem.staffID = 1;
            TestItem.totalPrice = 12.50;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.orderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }



        /*    REMOVED AS PER TUTORIAL !!
         * public void ListAndCountOK()
         {
             clsOrderCollection AllOrders = new clsOrderCollection();
             List<clsOrder> TestList = new List<clsOrder>();
             clsOrder TestItem = new clsOrder();
             TestItem.paid = true;
             TestItem.customerID = 1;
             TestItem.dateOrdered = DateTime.Today.Date;
             TestItem.deliveryAddress = "LE30HH";
             TestItem.orderID = 2;
             TestItem.staffID = 3;
             TestItem.totalPrice = 12.50;
             TestList.Add(TestItem);
             AllOrders.OrderList = TestList;
             Assert.AreEqual(AllOrders.Count, TestList.Count);
         }
        
         * [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);

        }
        */
    }
    }

