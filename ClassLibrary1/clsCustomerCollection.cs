using System;
using System.Collections.Generic;
using ShoeClasses;

namespace ClassLibrary1
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.DateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                ACustomer.Registered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Registered"]);
                ACustomer.Balance = Convert.ToDouble(DB.DataTable.Rows[Index]["Balance"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}