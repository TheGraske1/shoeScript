﻿using System;
using System.Collections.Generic;
using ShoeClasses;

namespace ShoeClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.staffid = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.name = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                AnStaff.phoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                AnStaff.salary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                AnStaff.joinedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinedDate"]);
                AnStaff.admin = Convert.ToBoolean(DB.DataTable.Rows[0]["AdminPriviligies"]);

                mStaffList.Add(AnStaff);
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public Int32 Count
        {
            get
            {
                return mStaffList.Count;
            } set
            {
                //null
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }



        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", mThisStaff.name);
            DB.AddParameter("@PhoneNumber", mThisStaff.phoneNumber);
            DB.AddParameter("@Salary", mThisStaff.salary);
            DB.AddParameter("@JoinedDate", mThisStaff.joinedDate);
            DB.AddParameter("@Admin", mThisStaff.admin);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.staffid);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.staffid);
            DB.AddParameter("@StaffName", mThisStaff.name);
            DB.AddParameter("@PhoneNumber", mThisStaff.phoneNumber);
            DB.AddParameter("@Salary", mThisStaff.salary);
            DB.AddParameter("@JoinedDate", mThisStaff.joinedDate);
            DB.AddParameter("@Admin", mThisStaff.admin);

            DB.Execute("sproc_tblStaff_Update");
        }
    }
}