using System;
using System.Collections.Generic;
using ShoeClasses;


namespace ClassLibrary1
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        //clsReview mThisReview = new clsReview();

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
                //chal we'll see
            }
        }

        public clsReview ThisReview { get; set; }

        public clsReviewCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReview_SelectAll");
            RecordCount = DB.Count;
            while (Index <  RecordCount)
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
    }
}