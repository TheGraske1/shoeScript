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
        string Salary = "25000";
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
            Int32 StaffId = 1;
            Found = AnStaff.Find(StaffId);
            if(AnStaff.staffid != 1)
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
        
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "a";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "a a";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = AnStaff.Valid(StaffName, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestJoinedDate;
            TestJoinedDate = DateTime.Now.Date;
            TestJoinedDate = TestJoinedDate.AddYears(-50);
            string JoinedDate = TestJoinedDate.ToString();
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestJoinedDate;
            TestJoinedDate = DateTime.Now.Date;
            TestJoinedDate = TestJoinedDate.AddDays(-1);
            string JoinedDate = TestJoinedDate.ToString();
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestJoinedDate;
            TestJoinedDate = DateTime.Now.Date;
            string JoinedDate = TestJoinedDate.ToString();
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestJoinedDate;
            TestJoinedDate = DateTime.Now.Date;
            TestJoinedDate = TestJoinedDate.AddDays(1);
            string JoinedDate = TestJoinedDate.ToString();
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateExtrememMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestJoinedDate;
            TestJoinedDate = DateTime.Now.Date;
            TestJoinedDate = TestJoinedDate.AddYears(50);
            string JoinedDate = TestJoinedDate.ToString();
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinedDateInvalidDate()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string JoinedDate = "this is not a date";
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNum = "";
            Error = AnStaff.Valid(Name, PhoneNum, Salary, JoinedDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
