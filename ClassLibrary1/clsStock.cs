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

        public string Valid(string styleName, string backInStockDate, string price, string quantityAvailable)
        {
            String Error = "";
            DateTime DateTemp;

            if (styleName.Length == 0)
            {
                Error = Error + "The Style Name may not be blank";
            }
            if (styleName.Length > 50)
            {
                Error = Error + "The Style Name must not be longer than 50 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(backInStockDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Back In Stock Date can not be in the past ";
                }
                if (DateTemp > DateTime.Now.Date.AddDays(31))
                {
                    Error = Error + "The Back In Stock Date can not be morethan 1 Month in Futeure: ";
                }
            }
            catch
            {
                Error = Error + "The Back In Stock was not valid Date";
            }

            if (price.Length == 0)
            {
                Error = Error + "Price can not be left blank";
            }
            if(price.Length > 9)
            {
                Error = Error + "Price can not be grether then 9 charecter including decimal";
            }

            if(quantityAvailable.Length == 0)
            {
                Error = Error + "Quantity Available may not be blank";
            }
            
            if(quantityAvailable.Length > 4)
            {
                Error = Error + "Quantity Available can not be more then 4 charecter";
            }
           

            return Error;
        }
    }
}