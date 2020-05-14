using ShoeClasses;
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

        public bool Find(int ReviewID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ReviewID", ReviewID);

            DB.Execute("sproc_tblReview_FilterByReviewID");

            if (DB.Count == 1)
            {
                mReviewID = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewID"]);
                mReviewDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReviewDate"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mReview = Convert.ToString(DB.DataTable.Rows[0]["Review"]);
                mProductRating = Convert.ToInt32(DB.DataTable.Rows[0]["ProductRating"]);
                mVerifiedCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["VerifiedCustomer"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string reviewdate, string product, string customer, string review, string productrating)

        {
            return "";
        }

           

    }
}