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

        public string Valid(string staffName, string phoneNum, string salary, string joinedDate)
        {
            string Error = "";
            DateTime TempDate;
            

            if(staffName.Length == 0)
            {
                Error = Error + "The staff name may not be left blank";
            }
            if(staffName.Length > 26)
            {
                Error = Error + "The staff name must not be longer than 25 characters";
            }

            try
            {
                TempDate = Convert.ToDateTime(joinedDate);
                if (TempDate < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (TempDate > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }catch
            {
                Error = Error + "This date was not a valid date";
            }

            if(Convert.ToDouble(salary) == 0)
            {
                Error = Error + "The salary may not be left blank";
            }

            if(salary.Length > 10)
            {
                Error = Error + "The salary must not be longer than 10 characters";
            }
            if(phoneNum.Length == 0)
            {
                Error = Error + "The phone number may not be left blank";
            }

 
            return Error;
        }
    }
}