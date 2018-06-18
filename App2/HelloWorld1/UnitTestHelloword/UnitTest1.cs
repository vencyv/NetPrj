
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld1;
namespace UnitTestHelloword
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual("Hello World!", Program.CreatMesg());
           // Assert.AreEqual("Hello cat", "bat");

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Hello World!", Program.CreatMesg());
            // Assert.AreEqual("Hello cat", "bat");

        }
    }
}
