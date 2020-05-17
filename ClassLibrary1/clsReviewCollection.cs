using System.Collections.Generic;
using System;


namespace ShoeClasses
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();


        public clsReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReview_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReviewList = new List<clsReview>();
            while (Index < RecordCount)
            {
                clsReview AReview = new clsReview();
                
                AReview.ReviewID = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewID"]);
                AReview.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AReview.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AReview.ReviewDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReviewDate"]);
                AReview.ProductRating = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductRating"]);
                
                mReviewList.Add(AReview);
                Index++;
            }
        }

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

        public void ReportByReview(string Review)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Review", Review);
            DB.Execute("sproc_tblReview_FilterByReview");
            PopulateArray(DB);
        }
    }
}