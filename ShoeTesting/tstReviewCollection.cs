using System;
using ShoeClasses;
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

        /*[TestMethod]
        public void CountPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Int32 SomeCount = 2;
            AllReviews.Count = SomeCount;
            Assert.AreEqual(AllReviews.Count, SomeCount);
        }
        */

        [TestMethod]
        public void ThisReviewPropertyOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReview TestReview = new clsReview();

            TestReview.VerifiedCustomer = false;
            TestReview.ReviewID = 1;
            TestReview.CustomerID = 1;
            TestReview.ProductID = 1;
            TestReview.ReviewDate = DateTime.Now.Date;
            TestReview.ProductRating = 1;
            TestReview.Review = "Terrible Product";

            AllReviews.ThisReview = TestReview;
            Assert.AreEqual(AllReviews.ThisReview, TestReview);


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


        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();
            Assert.AreEqual(AllReviews.Count, 2); ;
        }
        */

        [TestMethod]
        public void AddMethodOk()
        {
            clsReviewCollection AllReviews = new clsReviewCollection(); ;
            clsReview TestItem = new clsReview();
            Int32 PrimaryKey = 0;
            TestItem.VerifiedCustomer = true;
            TestItem.ReviewID = 7;
            TestItem.CustomerID = 6;
            TestItem.ProductID = 1;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 4;
            TestItem.Review = "Amazing product, would recommend to all students!";
            AllReviews.ThisReview = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewID = PrimaryKey;
            AllReviews.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReview, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection(); ;
            clsReview TestItem = new clsReview();
            Int32 PrimaryKey = 0;
            TestItem.VerifiedCustomer = true;
            TestItem.ReviewID = 7;
            TestItem.CustomerID = 6;
            TestItem.ProductID = 1;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 4;
            TestItem.Review = "Amazing product, would recommend to all students!";
            AllReviews.ThisReview = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewID = PrimaryKey;
            AllReviews.ThisReview.Find(PrimaryKey);
            AllReviews.Delete();
            Boolean Found = AllReviews.ThisReview.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection(); ;
            clsReview TestItem = new clsReview();
            Int32 PrimaryKey = 0;
            TestItem.VerifiedCustomer = true;
            TestItem.ReviewID = 7;
            TestItem.CustomerID = 6;
            TestItem.ProductID = 1;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 4;
            TestItem.Review = "Amazing product, would recommend to all students!";

            AllReviews.ThisReview = TestItem;
            PrimaryKey = AllReviews.Add();
            TestItem.ReviewID = PrimaryKey;

            TestItem.VerifiedCustomer = false;
            TestItem.ReviewID = 9;
            TestItem.CustomerID = 5;
            TestItem.ProductID = 3;
            TestItem.ReviewDate = DateTime.Now.Date;
            TestItem.ProductRating = 5;
            TestItem.Review = "PHENOMENAL product!!!!";
            AllReviews.ThisReview = TestItem;
            AllReviews.Update();

            AllReviews.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(AllReviews.ThisReview, TestItem);

        }

        [TestMethod]
        public void ReportByReviewDateOK()
        {
            clsReviewCollection AllReviews = new clsReviewCollection();

            clsReviewCollection FilteredReviews = new clsReviewCollection();

            FilteredReviews.ReportByReview("");

            Assert.AreEqual(AllReviews.Count, FilteredReviews.Count);
           
        }
    }
}
