using System;

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
        //public int ProductId { get; set; }
        

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

        public bool Find(int productId)
        {
            mProductId = 1;
            mStyleName = "Test Style Name";
            mQuantityAvailable = 10;

            return true;
        }

    }
}