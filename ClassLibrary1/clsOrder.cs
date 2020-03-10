using System;

namespace ShoeClasses

{
    public class clsOrder
    {
        private Int32 morderID;
        private DateTime mDateOrdered;
        private Boolean mPaid;
        private String mDeliveryAddress;
        private Int32 mCustomerID;
        private Int32 mStaffID;
        private double mTotalPrice;
        public DateTime dateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }
        public bool paid
        {
            get
            {
                return mPaid;
            }
            set
            {
                mPaid = value;
            }
        }
        public string deliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }
  
        public int orderID {

            get
            {
                return morderID;
            }
            set
            {

                morderID = Convert.ToInt32(value);
            }
            }
        public int customerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public int staffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public double totalPrice
        {
            get
            {
                return mTotalPrice;

            }
            set
            {
                mTotalPrice = Convert.ToInt32(value);
            }
        }
        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                morderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOrdered"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["totalPrice"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["staffID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["paid"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["deliveryAddress"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string date, string paid, string price, string staff, string customer,string address)
        {
            return "";
        }
    }
}