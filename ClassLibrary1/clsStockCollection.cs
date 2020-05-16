using ShoeClasses;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class clsStockCollection
    {
        List<clsStock> mProductList = new List<clsStock>();

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_ProductTable_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AProduct = new clsStock();
                AProduct.LimitedEdition = Convert.ToBoolean(DB.DataTable.Rows[Index]["LimitedEdition"]);
                AProduct.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AProduct.StyleName = Convert.ToString(DB.DataTable.Rows[Index]["StyleName"]);
                AProduct.QuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityAvailable"]);
                AProduct.BackInStockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BackInStockDate"]);
                AProduct.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                mProductList.Add(AProduct);
                Index++;
            }
        }

        public List<clsStock> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {
                
            }
        }
        public clsStock ThisProduct { get; set; }
    }
}