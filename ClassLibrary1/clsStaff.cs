using ShoeClasses;
using System;


namespace ShoeClasses
{
    public class clsStaff
    {
        public clsStaff()
        {
        }
        private Int32 mStaffId;
        private string mStaffName;
        private string mPhoneNumber;
        private DateTime mJoinedDate;
        private double mSalary;
        private bool mAdmin;

        public int staffid
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }
        public string name
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public string phoneNumber {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }
        public DateTime joinedDate {
            get
            {
                return mJoinedDate;
            }
            set
            {
                mJoinedDate = value;
            }
        }
        public double salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public bool admin {
            get
            {
                return mAdmin;
            }
            set
            {
                mAdmin = value;
            }
        }

        public bool Find(int staffid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", staffid);
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            if(DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mJoinedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinedDate"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["AdminPriviligies"]);
                return true;
    }
            else
            {
                return false;
            }
        }

        public string Valid(string name, string phoneNum, double salary, string joinedDate)
        {
            return "";
        }
    }
}