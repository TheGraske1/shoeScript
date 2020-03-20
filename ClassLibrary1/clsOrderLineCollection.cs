using System.Collections.Generic;
using System;
namespace ShoeClasses
{
    public class clsOrderLineCollection
    {
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



        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
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
        public clsOrderLine ThisOrderLine { get; set; }
    }
}
    
