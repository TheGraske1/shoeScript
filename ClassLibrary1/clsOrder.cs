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
            morderID = 12;
            mDateOrdered = Convert.ToDateTime("16/02/2020");
            mTotalPrice = 10.50;
            mStaffID = 4;
            mCustomerID = 3;
            mPaid = true;
            mDeliveryAddress = "Test address";

            return true;
        }
    }
}