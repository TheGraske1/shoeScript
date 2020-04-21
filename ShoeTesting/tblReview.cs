using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tblReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();

            Assert.IsNotNull(AReview);
        }
    }
}
