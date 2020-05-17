using System.Collections.Generic;
using System;
using ClassLibrary1;
using ShoeClasses;

namespace ClassLibrary1
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();

        public List<clsReview> ReviewList
        {
            get
            {
                return mReviewList;
            }
            set
            {
                mReviewList = value;
            }
        }

        public int Count
        {
            get
            {
                return mReviewList.Count;
            }
            set
            {
                //Waheguru
            }
        }

        public clsReview ThisReview
        {
            get
            {
                return mThisReview;
            }
            set
            {
                mThisReview = value;
            }
        }

        public clsReviewCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReview_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsReview AReview = new clsReview();

                AReview.ReviewID = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewID"]);
                AReview.ReviewDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReviewDate"]);
                AReview.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AReview.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AReview.Review = Convert.ToString(DB.DataTable.Rows[Index]["Review"]);
                AReview.ProductRating = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductRating"]);
                AReview.VerifiedCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["VerifiedCustomer"]);

                mReviewList.Add(AReview);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("CustomerID", mThisReview.CustomerID);
            DB.AddParameter("ProductID", mThisReview.ProductID);
            DB.AddParameter("ReviewDate", mThisReview.ReviewDate);
            DB.AddParameter("Review", mThisReview.Review);
            DB.AddParameter("ProductRating", mThisReview.ProductRating);
            DB.AddParameter("VerifiedCustomer", mThisReview.VerifiedCustomer);

            return DB.Execute("sproc_tblReview_Insert"); ;
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewID", mThisReview.ReviewID);
            DB.Execute("sproc_tblReview_Delete"); 
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("ReviewID", mThisReview.ReviewID);
            DB.AddParameter("CustomerID", mThisReview.CustomerID);
            DB.AddParameter("ProductID", mThisReview.ProductID);
            DB.AddParameter("ReviewDate", mThisReview.ReviewDate);
            DB.AddParameter("Review", mThisReview.Review);
            DB.AddParameter("ProductRating", mThisReview.ProductRating);
            DB.AddParameter("VerifiedCustomer", mThisReview.VerifiedCustomer);

            DB.Execute("sproc_tblReview_Update"); 
        }

        public void ReportByReviewDate(DateTime ReviewDate)
        {
            //Filters the records based on the Review Date
        }
    }
}