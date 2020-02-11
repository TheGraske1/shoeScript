using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }
    }
}
