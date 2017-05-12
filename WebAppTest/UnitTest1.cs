using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication4;

namespace WebAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOK()
        {
            bool flag = Utility.IsOk();
            Assert.IsTrue(flag);
        }
    }
}
