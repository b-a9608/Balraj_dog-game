using System;
using Balraj_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Balraj_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (BalrajGreyhound.move() > 5)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
