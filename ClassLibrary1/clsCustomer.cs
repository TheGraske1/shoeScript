using System;

namespace ClassLibrary1
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private DateTime mDateCreated;
        private string mName;
        private string mAddress;
        private bool mRegistered;
        private double mBalance;

        public clsCustomer()
        {
        }

        public string name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public DateTime createdDate
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }
        public bool Registered
        {
            get
            {
                return mRegistered;
            }
            set
            {
                mRegistered = value;
            }
        }

        public double balance
        {
            get
            {
                return mBalance;
            }
            set
            {
                mBalance = value;

            }
        }

        public Int32 CustomerID
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

        public bool Find(int customerID)
        {
            mCustomerID = 6;
            mDateCreated = Convert.ToDateTime("02/03/2020");
            mName = "Joe";
            mAddress = "3 Apple Street LE1 8DS";
            mRegistered = false;
            mBalance = 250.00;
            return true;
        }
    }
}