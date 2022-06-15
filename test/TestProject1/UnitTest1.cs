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
        [TestMethod]
        public void MyCalc_Sub_Test1_1()
        {
            MyCalc calc = new MyCalc();
            var result = calc.Sub(3, 1);
            Assert.AreEqual(2, result, "3-1=2");
        }
        [TestMethod]
        public void MyCalc_Mul_Test1_1()
        {
            MyCalc calc = new MyCalc();
            var result = calc.Mul(3, 2);
            Assert.AreEqual(6, result, "3*2=6");
        }
        [TestMethod]
        public void MyCalc_Div_Test1_1()
        {
            MyCalc calc = new MyCalc();
            var result = calc.Div(6, 2);
            Assert.AreEqual(3, result, "6/2=3");
        }
    }
}
