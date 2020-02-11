using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
