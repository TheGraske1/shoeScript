using System;
using ShoeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstStaff
    {

        string Name = "John Doe";
        string PhoneNum = "012345678912";
        int Salary = 25000;
        string JoinedDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance
            clsStaff AnStaff = new clsStaff();
            //test is exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffName()
        {
            clsStaff AnStaff = new clsStaff();
            string testName= "John Doe";
            AnStaff.name = testName;
            Assert.AreEqual(AnStaff.name, testName);
        }

        [TestMethod]
        public void StaffPNumber()
        {
            clsStaff AnStaff = new clsStaff();
            string testPNum = "012345678915";
            AnStaff.phoneNumber = testPNum;
            Assert.AreEqual(AnStaff.phoneNumber, testPNum);
        }

        [TestMethod]
        public void StaffJoinDate()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime testDate = DateTime.Now.Date;
            AnStaff.joinedDate = testDate;
            Assert.AreEqual(AnStaff.joinedDate, testDate);
        }

        [TestMethod]
        public void StaffSalary()
        {
            clsStaff AnStaff = new clsStaff();
            double testSalary = 25000.95;
            AnStaff.salary = testSalary;
            Assert.AreEqual(AnStaff.salary, testSalary);
        }

        [TestMethod]
        public void StaffAdminPriv()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean testAdminPriv = true;
            AnStaff.admin = testAdminPriv;
            Assert.AreEqual(AnStaff.admin, testAdminPriv);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = AnStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStaffNoFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.staffid != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStaffNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.name != "John Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPhoneNumberFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.phoneNumber != "01234567891")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSalaryFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.salary != 25000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestJoinedDateFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.joinedDate != Convert.ToDateTime("01/04/1995"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestAdminFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.admin != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

    }
}
