using ShoeClasses;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class clsStockCollection
    {
        List<clsStock> mProductList = new List<clsStock>();
        clsStock mThisProduct = new clsStock();
        public clsStockCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_ProductTable_SelectAll");
            PopulateArray(DB);
            
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mProductList = new List<clsStock>();
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
        public clsStock ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StyleName", mThisProduct.StyleName);
            DB.AddParameter("@QuantityAvailable", mThisProduct.QuantityAvailable);
            DB.AddParameter("@BackInStockDate", mThisProduct.BackInStockDate);
            DB.AddParameter("@LimitedEdition", mThisProduct.LimitedEdition);
            DB.AddParameter("@Price", mThisProduct.Price);
            return DB.Execute("sproc_ProductTable_Insert");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.Execute("sproc_ProductTable_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@StyleName", mThisProduct.StyleName);
            DB.AddParameter("@QuantityAvailable", mThisProduct.QuantityAvailable);
            DB.AddParameter("@BackInStockDate", mThisProduct.BackInStockDate);
            DB.AddParameter("@LimitedEdition", mThisProduct.LimitedEdition);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.Execute("sproc_ProductTable_Update");
        }

        public void ReportByStyleName(string StyleName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StyleName", StyleName);
            DB.Execute("sproc_PtoductTable_FilterByStyleName");
            PopulateArray(DB);
        }

    }
}