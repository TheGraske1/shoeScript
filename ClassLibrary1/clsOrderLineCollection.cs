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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.orderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["orderLineID"]);
                AnOrderLine.orderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                AnOrderLine.productID = Convert.ToInt32(DB.DataTable.Rows[0]["productID"]);
                AnOrderLine.quantity = Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                AnOrderLine.selectionDescription = Convert.ToString(DB.DataTable.Rows[0]["selectionDescription"]);
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
    }
}
    
