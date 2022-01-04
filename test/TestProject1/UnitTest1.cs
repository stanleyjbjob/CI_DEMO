using CI_DEMO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyCalc_Add_Test1_1()
        {
            MyCalc calc = new MyCalc();
            var result = calc.Add(1, 1);
            Assert.AreEqual(2, result, "1+1=2");
        }
    }
}
