using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject151
{
    [TestClass]
    public class UnitTest1
    {
       public static bool Test1Called=false;
        public static bool Test2Called=false;
        public static bool Test3Called=false;

        [TestMethod]
        public void TestMethod1()
        {
            Test1Called = true;

            Assert.IsFalse(Test2Called);
            Assert.IsFalse(Test3Called);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Test2Called = true;

            Assert.IsTrue(Test1Called);
            Assert.IsFalse(Test3Called);
        }
      

        [TestMethod]
        public void TestMethod3()
        {
            Test3Called = true;

            Assert.IsTrue(Test1Called);
            Assert.IsTrue(Test2Called);
        }

    
    }
}
