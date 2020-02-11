using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerName()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testName = "Jay Patel";
            ACustomer.name = testName;
            Assert.AreEqual(ACustomer.name, testName);
        }

        [TestMethod]
        public void Address()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestAddress = "41 Rope Walk";
            ACustomer.Address = TestAddress;
            Assert.AreEqual(ACustomer, TestAddress);
        }

        [TestMethod]
        public void DateCreated()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime testDate = DateTime.Now.Date;
            ACustomer.createdDate = testDate;
            Assert.AreEqual(ACustomer.createdDate, testDate);
        }

        [TestMethod]
        public void Account()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean testCustomerAccount = true;
            ACustomer.account = testCustomerAccount;
            Assert.AreEqual(ACustomer.account, testCustomerAccount);
        }

        [TestMethod]
        public void Balance()
        {
            clsCustomer ACustomer = new clsCustomer();
            double testBalance = 250.00;
            ACustomer.balance = testBalance;
            Assert.AreEqual(ACustomer.balance, testBalance);
        }
    }
}
