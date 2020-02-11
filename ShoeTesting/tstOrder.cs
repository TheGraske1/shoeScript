using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
