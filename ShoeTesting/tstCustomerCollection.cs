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

        [TestMethod]
        public void UpdateMethodOK()
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

            TestItem.Name = "kate";
            TestItem.Address = "234 Newarke Street LE1 2AD";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Registered = false;
            TestItem.Balance = 100.00;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByName("Rebecca");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomer.ReportByName("kate");
            if (FilteredCustomer.Count == 5)
            {
                if (FilteredCustomer.CustomerList[0].CustomerID != 12)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[1].CustomerID != 15)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[2].CustomerID != 18)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[3].CustomerID != 21)
                {
                    OK = false;
                }
                if (FilteredCustomer.CustomerList[4].CustomerID != 24)
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
    }
}
