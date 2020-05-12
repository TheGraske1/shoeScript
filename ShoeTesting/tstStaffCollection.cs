using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses;


namespace ShoeTesting
{
    [TestClass]
    public class testStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            //set properties
            TestItem.staffid = 1;
            TestItem.name = "Joe Bloggs";
            TestItem.phoneNumber = "01234567891";
            TestItem.salary = 25000.24;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            //set properties
            TestStaff.staffid = 1;
            TestStaff.name = "Joe Bloggs";
            TestStaff.phoneNumber = "01234567891";
            TestStaff.salary = 25000.24;
            TestStaff.joinedDate = DateTime.Now.Date;
            TestStaff.admin = true;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            //set properties
            TestItem.staffid = 1;
            TestItem.name = "Joe Bloggs";
            TestItem.phoneNumber = "01234567891";
            TestItem.salary = 25000.24;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            //set properties
            TestItem.staffid = 1;
            TestItem.name = "Joe Bloggs";
            TestItem.phoneNumber = "01234567891";
            TestItem.salary = 25000.24;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staffid = PrimaryKey;

            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            //set properties
            TestItem.staffid = 1;
            TestItem.name = "Joe Bloggs";
            TestItem.phoneNumber = "01234567891";
            TestItem.salary = 25000.24;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            //set properties
            TestItem.staffid = 1;
            TestItem.name = "Joe Bloggs";
            TestItem.phoneNumber = "01234567891";
            TestItem.salary = 25000.24;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staffid = PrimaryKey;

            //set properties (updated)
            TestItem.staffid = 3;
            TestItem.name = "Bloggs Joe";
            TestItem.phoneNumber = "19876543210";
            TestItem.salary = 15000.99;
            TestItem.joinedDate = DateTime.Now.Date;
            TestItem.admin = false;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void ReportByPhoneNumber()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByPhoneNumber("54321098761");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByPhoneNumberTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByPhoneNumber("01234567891");

            if (FilteredStaff.Count == 2)
            {
                if(FilteredStaff.StaffList[0].staffid != 9)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].staffid != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }

}

