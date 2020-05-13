using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;

namespace ShoeTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerID = 3;
            TestItem.Name = "Jay";
            TestItem.Address = "131 Gateway Street LE3 1DW";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Registered = true;
            TestItem.Balance = 250.00;

            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);

        }



        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.CustomerID = 3;
            TestCustomer.Name = "Jay";
            TestCustomer.Address = "131 Gateway Street LE3 1DW";
            TestCustomer.DateCreated = DateTime.Now.Date;
            TestCustomer.Registered = true;
            TestCustomer.Balance = 250.00;

            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 7;
            TestItem.Name = "Kyle";
            TestItem.Address = "234 New Walk Street LE1 2AD";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Registered = true;
            TestItem.Balance = 500.00;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            
            TestItem.Name = "Kyle";
            TestItem.Address = "234 New Walk Street LE1 2AD";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Registered = true;
            TestItem.Balance = 500.00;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

    }
}
