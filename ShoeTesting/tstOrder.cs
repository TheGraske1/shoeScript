using System;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void IstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void PaidPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.paid = TestData;
            Assert.AreEqual(AnOrder.paid, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.dateOrdered = TestData;
            Assert.AreEqual(AnOrder.dateOrdered, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Some address";
            AnOrder.deliveryAddress = TestData;
            Assert.AreEqual(AnOrder.deliveryAddress, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.orderID = TestData;
            Assert.AreEqual(AnOrder.orderID, TestData);
        }
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1234;
            AnOrder.customerID = TestData;
            Assert.Equals(AnOrder.customerID, TestData);
        }
        public void StaffIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 123;
            AnOrder.staffID = TestData;
            Assert.Equals(AnOrder.staffID, TestData);
        }
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            double TestData = 5.62;
            AnOrder.totalPrice = TestData;
            Assert.Equals(AnOrder.totalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 orderID = 12;
            Found = AnOrder.Find(orderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderNotFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            Found = AnOrder.Find(orderID);
            if (AnOrder.orderID != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            Found = anOrder.Find(orderID);
            if(anOrder.dateOrdered != Convert.ToDateTime("16/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if(anOrder.customerID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.staffID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.totalPrice != 10.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.deliveryAddress != "Test address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestPaidFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 orderID = 12;
            found = anOrder.Find(orderID);
            if (anOrder.paid != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            DateTime dateToday = DateTime.Today.Date;
            string date = Convert.ToString(dateToday);
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "2";
            string address = "14 Emerald, Leicester, LE3 5GA";
            error = AnOrder.Valid(date, paid, price, staff, customer, address);
               Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime dateToday = DateTime.Today.Date;
            string date = Convert.ToString(dateToday);
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "0";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "0");

        }
        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime dateToday = DateTime.Today.Date;
            string date = Convert.ToString(dateToday);
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime dateToday = DateTime.Today.Date;
            string date = Convert.ToString(dateToday);
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "2";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "99998";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "99999";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "50000";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string date = "02/03/2020";
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "100000";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string date = "02/03/2020";
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "500000";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateOrderedMinOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOrderedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string date = "This is not a date!";
            string paid = "True";
            string price = "20.99";
            string staff = "3";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "0";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "1";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "2";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "49";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIDMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "50";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "51";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "25";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "100";
            string customer = "1";
            string address = "14 Emerald, Leicester, LE3 5GA";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "a";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "aa";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxMinOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            address = address.PadRight(99, 'a');
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
       
        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            address = address.PadRight(100, 'a');
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            address = address.PadRight(101, 'a');
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            address = address.PadRight(50, 'a');
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            address = address.PadRight(200, 'a');
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaidMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaidMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "True";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "a";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaidMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "False";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "a";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaidInvalidStringData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "a";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "a";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaidInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string date = TestDate.ToString();
            string paid = "I want to go home 52";
            string price = "20.99";
            string staff = "20";
            string customer = "1";
            string address = "a";
            Error = AnOrder.Valid(date, paid, price, staff, customer, address);
            Assert.AreNotEqual(Error, "");
        }
       
    }
}
