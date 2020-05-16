using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoeTesting
{
    [TestClass]
    public class tstReviewCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Assert.IsNotNull(AllReviews);
        }

        [TestMethod]
        public void ReviewListOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();

            clsReview TestItem = new clsReview();
            TestItem.VerifiedCustomer = true;
            TestItem.ReviewID = 7;
            TestItem.CustomerID = 6;
            TestItem.ProductID = 20;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 4;
            TestItem.Review = "Amazing product, would recommend to all students!";

            TestList.Add(TestItem);
            AllReviews.ReviewList = TestList;
            Assert.AreEqual(AllReviews.ReviewList, TestList); ;
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Int32 SomeCount = 2;
            AllReviews.Count = SomeCount;
            Assert.AreEqual(AllReviews.Count, SomeCount);
        }


        [TestMethod]
        public void ThisReviewPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestReview = new clsReview();

            TestReview.VerifiedCustomer = true;
            TestReview.ReviewID = 7;
            TestReview.CustomerID = 6;
            TestReview.ProductID = 20;
            TestReview.ReviewDate = DateTime.Now.Date;
            TestReview.ProductRating = 4;
            TestReview.Review = "Amazing product, would recommend to all students!";

            AllReviews.ThisReview = TestReview;
            Assert.AreEqual(AllReviews.ThisReview, TestReview); ;


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();
            clsReview TestItem = new clsReview();
            TestItem.VerifiedCustomer = true;
            TestItem.ReviewID = 7;
            TestItem.CustomerID = 6;
            TestItem.ProductID = 20;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 4;
            TestItem.Review = "Amazing product, would recommend to all students!";

            TestList.Add(TestItem);
            AllReviews.ReviewList = TestList;
            Assert.AreEqual(AllReviews.Count, TestList.Count); 
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Assert.AreEqual(AllReviews.Count, 2); ;
        }
    }
}
