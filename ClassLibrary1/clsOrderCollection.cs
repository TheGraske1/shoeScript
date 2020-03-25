using System;
using System.Collections.Generic;

namespace ShoeClasses
{

    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while(Index< RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.paid = Convert.ToBoolean(DB.DataTable.Rows[0]["paid"]);
                AnOrder.customerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                AnOrder.dateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOrdered"]);
                AnOrder.deliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["deliveryAddress"]);
                AnOrder.orderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                AnOrder.staffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                AnOrder.totalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
            }


        }
        
        public List<clsOrder> OrderList { get 
            {
                return mOrderList;
            } set 
            {
                mOrderList = value;          
            } 
        }

        public int Count { get 
            {
                return mOrderList.Count;
            } set 
            {
            
            } 
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", mThisOrder.orderID);
            DB.AddParameter("@customerID", mThisOrder.customerID);
            DB.AddParameter("@staffID", mThisOrder.staffID);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@paid", mThisOrder.paid);
            DB.AddParameter("@deliveryAddress", mThisOrder.deliveryAddress);
            DB.AddParameter("@dateOrdered", mThisOrder.dateOrdered);
            return DB.Execute("sproc_OrderTable_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderLineID", mThisOrder.orderID);
            DB.Execute("sproc_tblOrderLine_Delete");
        }
    }
    
   

   
    }
