using System;
using ShoeClasses;

namespace ClassLibrary1
{
    public class clsStock
    {
        private Int32 mProductId;
        private string mStyleName;
        private Int32 mQuantityAvailable;
        private Boolean mLimitedEdition;
        private DateTime mBackInStockDate;
        private double mPrice;

        public bool LimitedEdition
        {
            get
            {
                return mLimitedEdition;
            }
            set
            {
                mLimitedEdition = value;
            }
        }
        public DateTime BackInStockDate
        {
            get
            {
                return mBackInStockDate;
            }
            set
            {
                mBackInStockDate = value;
            }
        }
        public Int32 QuantityAvailable
        {
            get
            {
                return mQuantityAvailable;

            }
            set
            {
                mQuantityAvailable = value;
            }
        }
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value; 
            }
        }
        public string StyleName
        {
            get
            {
                return mStyleName;
            }
            set
            {
                mStyleName = value;
            }
        }
     
        

        public Int32 ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }

        public bool Find(int ProductId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_ProductTable_FilterByProductId");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mStyleName = Convert.ToString(DB.DataTable.Rows[0]["StyleName"]);
                mBackInStockDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BackInStockDate"]);
                mLimitedEdition = Convert.ToBoolean(DB.DataTable.Rows[0]["LimitedEdition"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityAvailable"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string StyleName, string BackInStockDate,  double Price, Int32 QuantityAvailable)
        {
            return "";
        }

    }
}