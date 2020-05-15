using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstReview
    {
        string reviewdate = DateTime.Now.Date.ToString();
        string product = "3";
        string customer = "4";
        string review = "Terrible Product";
        string productrating = "1";

        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);
        }
        [TestMethod]
        public void ReviewDateExists()
        {
            clsReview AReview = new clsReview();
            DateTime TestData = DateTime.Now.Date;
            AReview.ReviewDate = TestData;
            Assert.AreEqual(AReview.ReviewDate, TestData);
        }
        [TestMethod]
        public void ProductID()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.ProductID = TestData;
            Assert.AreEqual(AReview.ProductID, TestData);

        }
        [TestMethod]
        public void CustomerID()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.CustomerID = TestData;
            Assert.AreEqual(AReview.CustomerID, TestData);

        }

        [TestMethod]
        public void Review()
        {
            clsReview AReview = new clsReview();
            string TestData = "Unique approach to stability. Guide rails provide dynamic support that give a smooth ride. Breathable upper.Rediculously comfortable for running and walking.";
            AReview.Review = TestData;
            Assert.AreEqual(AReview.Review, TestData);
        }
        [TestMethod]
        public void ReviewID()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.ReviewID = TestData;
            Assert.AreEqual(AReview.ReviewID, TestData);
        }
        [TestMethod]
        public void ProductRating()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.ProductRating = TestData;
            Assert.AreEqual(AReview.ProductRating, TestData);
        }

        [TestMethod]
        public void VerifedCustomer()
        {
            clsReview AReview = new clsReview();
            Boolean TestData = true;
            AReview.VerifiedCustomer = TestData;
            Assert.AreEqual(AReview.VerifiedCustomer, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsReview AReview = new clsReview();

            Boolean Found = false;

            Int32 ReviewID = 9;

            Found = AReview.Find(ReviewID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ReviewIDFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.ReviewID != 9)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ReviewDateFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.ReviewDate != Convert.ToDateTime("03/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductIDFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.ProductID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.CustomerID != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ReviewFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.Review != "Terrible Product")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductRatingFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.ProductRating != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void VerifiedCustomerFound()
        {
            clsReview AReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewID = 9;
            Found = AReview.Find(ReviewID);
            if (AReview.VerifiedCustomer != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewDateExtremeMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string reviewdate = TestDate.ToString();
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewDateMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string reviewdate = TestDate.ToString();
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewDateMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;

            string reviewdate = TestDate.ToString();
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ReviewDateMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string reviewdate = TestDate.ToString();
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReviewDateExtremeMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string reviewdate = TestDate.ToString();
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReviewDateInvalidData()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string reviewdate = "this is not a date!";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ReviewMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string review = "";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string review = "a";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string review = "aa";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "0";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "1";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "2";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "99998";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "99999";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMid()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "50000";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "100000";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string customer = "99999999";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductRatingMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "-1";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductRatingMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "0";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductRatingMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "1";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductRatingMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "4";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductRatingMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "5";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductRatingMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "6";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductRatingExtremeMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string productrating = "10";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMinLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "0";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMin()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "1";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "2";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "99998";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "99999";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMid()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "50000";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "100000";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            clsReview AReview = new clsReview();
            String Error = "";
            string product = "99999999";
            Error = AReview.Valid(reviewdate, product, customer, review, productrating);
            Assert.AreNotEqual(Error, "");

        }
    }
}






