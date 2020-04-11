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
        public void TestMethod1()
        {
        }

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
    }

}

