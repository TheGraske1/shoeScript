using System;

namespace ClassLibrary1
{
    public class clsReview
    {

        private Int32 mReviewID;
        private DateTime mReviewDate;
        private Int32 mProductID;
        private Int32 mCustomerID;
        private String mReview;
        private Int32 mProductRating;
        private Boolean mVerifiedCustomer;
        
        public DateTime ReviewDate
        {        
            get
            {
                return mReviewDate;
            }
            set
            {
                mReviewDate = value; 
            }
        }

        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public string Review
        {
            get
            {
                return mReview;
            }
            set
            {
                mReview = value;
            }
        }

        public int ReviewID
        {
            get
            {
                return mReviewID;
            }
            set
            {
                mReviewID = value;
            }
        }

        public int ProductRating
        {
            get
            {
                return mProductRating;
            }
            set
            {
                mProductRating = value;
            }
        }

        public bool VerifiedCustomer
        {
            get
            {
                return mVerifiedCustomer;
            }
            set
            {
                mVerifiedCustomer = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public bool Find(int reviewID)
        {
            mReviewID = 9;
            return true;
        }
    }
}