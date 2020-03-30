using System.Collections.Generic;
using System;
namespace ShoeClasses
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();
        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.orderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["orderLineID"]);
                AnOrderLine.orderID = Convert.ToInt32(DB.DataTable.Rows[Index]["orderID"]);
                AnOrderLine.productID = Convert.ToInt32(DB.DataTable.Rows[Index]["productID"]);
                AnOrderLine.quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["quantity"]);
                AnOrderLine.selectionDescription = Convert.ToString(DB.DataTable.Rows[Index]["selectionDescription"]);
                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }
        
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {

            }
        }
        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderLineID", mThisOrderLine.orderLineID);
            DB.AddParameter("@orderID", mThisOrderLine.orderID);
            DB.AddParameter("@productID", mThisOrderLine.productID);
            DB.AddParameter("@quantity", mThisOrderLine.quantity);
            DB.AddParameter("@selectionDescription", mThisOrderLine.selectionDescription);
            return DB.Execute("sproc_OrderLineTable_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderLineID", mThisOrderLine.orderLineID);
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderLineID", mThisOrderLine.orderLineID);
            DB.AddParameter("@orderID", mThisOrderLine.orderID);
            DB.AddParameter("@productID", mThisOrderLine.productID);
            DB.AddParameter("@quantity", mThisOrderLine.quantity);
            DB.AddParameter("@selectionDescription", mThisOrderLine.selectionDescription);
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void ReportBySelectionDescription(string SelectionDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SelectionDescription", SelectionDescription);
            DB.Execute("sproc_tblOrderLine_FilterBySelectionDescription");
            PopulateArray(DB);
        }
    }
}
    
