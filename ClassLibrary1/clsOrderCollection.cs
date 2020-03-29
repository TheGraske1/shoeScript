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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
           
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.paid = Convert.ToBoolean(DB.DataTable.Rows[0]["paid"]);
                AnOrder.customerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                AnOrder.dateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOrdered"]);
                AnOrder.deliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["deliveryAddress"]);
                AnOrder.orderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                AnOrder.staffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                AnOrder.totalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
                mOrderList.Add(AnOrder);
                Index++;
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
            DB.AddParameter("@orderID", mThisOrder.orderID);
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", mThisOrder.orderID);
            DB.AddParameter("@customerID", mThisOrder.customerID);
            DB.AddParameter("@staffID", mThisOrder.staffID);
            DB.AddParameter("@totalPrice", mThisOrder.totalPrice);
            DB.AddParameter("@paid", mThisOrder.paid);
            DB.AddParameter("@deliveryAddress", mThisOrder.deliveryAddress);
            DB.AddParameter("@dateOrdered", mThisOrder.dateOrdered);
            DB.Execute("sproc_tblOrder_Update");
        }
        public void ReportByDeliveryAddress(string deliveryAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@deliveryAddress", deliveryAddress);
            DB.Execute("sproc_tblOrder_FilterByDeliveryAddress");
            PopulateArray(DB);
        }
    }
    }
