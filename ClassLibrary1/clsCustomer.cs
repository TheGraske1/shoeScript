using ShoeClasses;
using System;

namespace ClassLibrary1
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }
        private Int32 mCustomerID;
        private DateTime mDateCreated;
        private string mName;
        private string mAddress;
        private bool mRegistered;
        private double mBalance;



        public string Name
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
        public DateTime DateCreated
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

        public double Balance
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

        public bool Find(int CustomerID)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", CustomerID);

            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                mRegistered = Convert.ToBoolean(DB.DataTable.Rows[0]["Registered"]);
                mBalance = Convert.ToDouble(DB.DataTable.Rows[0]["Balance"]);

                return true;
            }
            else
            {
                return false;
            }



            /*mCustomerID = 6;
            mDateCreated = Convert.ToDateTime("02/03/2020");
            mName = "Joe";
            mAddress = "48 Apple Street LE1 8DS";
            mRegistered = false;
            mBalance = 250.00;
            return true;*/
        }

        public string Valid(string Name,
                            string Address,
                            DateTime DateCreated,
                            Boolean Registered,
                            double Balance)
        {
            return "";
        }



    }
}