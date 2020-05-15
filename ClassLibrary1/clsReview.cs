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

        //public string Valid(string reviewdate, string product, string customerid, string review, string productrating)
        public string Valid(string reviewdate, string product, string customer, string review, string productrating)

        {
            String Error = "";
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(reviewdate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The  date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
                
            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (review.Length == 0)
            {
                Error = Error + "The review may not be blank : ";
            }                                        
                       
            if (Convert.ToInt32(customer) == 0)
            {
                Error = Error + "CustomerID cannot be 0";
            }
            if (Convert.ToInt32(customer) > 99999)
            {
                Error = Error + "CustomerID cannot be over 100000";
            }

            if (Convert.ToInt32(productrating) < 0)
            {
                Error = Error + "Product Rating cannot less than 0";
            }
            if (Convert.ToInt32(productrating) > 5)
            {
                Error = Error + "Product Rating cannot be over 5";
            }

            if (Convert.ToInt32(product) == 0)
            {
                Error = Error + "ProductID cannot be 0";
            }
            if (Convert.ToInt32(product) > 99999)
            {
                Error = Error + "ProductID cannot be over 100000";
            }
            
            return Error;


        }



        
                       
      

           

    }
}