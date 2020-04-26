using System;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace ShoeTesting
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);
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
        public void ProductID()
        {
            clsReview AReview = new clsReview();
            Int32 TestData = 1;
            AReview.ProductID = TestData;
            Assert.AreEqual(AReview.ProductID, TestData);
        }


        [TestMethod]
        public void Review()
        {
            clsReview AReview = new clsReview();
            string TestData = "Unique approach to stability. Guide rails provide dynamic support that give a smooth ride. Breathable upper.Rediculously comfortable for running and walking.";
            AReview.Review = TestDate;
            Assert.AreEqual(AReview.Review, TestData);
        }

        [TestMethod]
        public void ReviewDate()
        {
            clsReview AReview = new clsReview();
            DateTime TestData = DateTime.Now.Date;
            AReview.DateAdded = TestData;
            Assert.AreEqual(AReview.DateAdded, TestData);
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
            Assert.AreEqual(AnAddress.Active, TestData);
        }

    }
}
