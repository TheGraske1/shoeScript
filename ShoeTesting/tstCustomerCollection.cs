using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
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

        

       

    }
}
