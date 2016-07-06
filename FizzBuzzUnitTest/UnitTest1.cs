using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fizzbuzz_class;


namespace FizzBuzzUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Fizzbuzz_console = new Class1();

            int iter = 1;
            string result = Fizzbuzz_console.check(iter);
            Assert.AreEqual(result, 1.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Fizzbuzz_console = new Class1();

            int iter = 100;
            string result = Fizzbuzz_console.check(iter);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var Fizzbuzz_console = new Class1();

            int iter = 99;
            string result = Fizzbuzz_console.check(iter);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void TestMethod4()
        {
            var Fizzbuzz_console = new Class1();

            int iter = 90;
            string result = Fizzbuzz_console.check(iter);
            Assert.AreEqual(result, "FizzBuzz");
        }
    }
}
