using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstCustomer
    {
        DateTime dateCreated = Convert.ToDateTime("02/03/2020");
        string name = "Joe";
        string address = "48 Apple Street LE1 8DS";
        Boolean registered = false;
        Double balance = 250.00;



        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
       
        [TestMethod]
        public void CustomerID()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 testID = 1;
            ACustomer.CustomerID = testID;
            Assert.AreEqual(ACustomer.CustomerID, testID);
        }

        [TestMethod]
        public void CustomerName()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testName = "Jay Patel";
            ACustomer.Name = testName;
            Assert.AreEqual(ACustomer.Name, testName);
        }

        [TestMethod]
        public void Address()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestAddress = "48 Apple Street LE4 1AS";
            ACustomer.Address = TestAddress;
            Assert.AreEqual(ACustomer.Address, TestAddress);
        }

        [TestMethod]
        public void DateCreated()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime testDate = DateTime.Now.Date;
            ACustomer.DateCreated = testDate;
            Assert.AreEqual(ACustomer.DateCreated, testDate);
        }

        [TestMethod]
        public void Registered()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean testCustomerAccount = true;
            ACustomer.Registered = testCustomerAccount;
            Assert.AreEqual(ACustomer.Registered, testCustomerAccount);
        }

        [TestMethod]
        public void Balance()
        {
            clsCustomer ACustomer = new clsCustomer();
            double testBalance = 250.00;
            ACustomer.Balance = testBalance;
            Assert.AreEqual(ACustomer.Balance, testBalance);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        } 

        [TestMethod]

        public void TestCustomerNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;
            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerID != 6 )
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestDateCreatedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.DateCreated != Convert.ToDateTime("02/03/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Name != "Joe")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Address != "3 Apple Street LE1 8DS")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRegisteredFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Registered != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestBalanceFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 6;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Balance != 250.00)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }



        [TestMethod]

        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";

            Error = ACustomer.Valid(name, address, dateCreated, registered, balance);
            Assert.AreEqual(Error, "");
        }


    }
}
