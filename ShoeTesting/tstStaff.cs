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
    }
}
