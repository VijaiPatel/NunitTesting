using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitTesting;

namespace MyTestProject
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void AddTest()// test Add method
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void SubtractTest() // test subtract method
        {
            Calc c = new Calc();
            double x = 10.0;
            double y = 5.0;
            double expectedValue = 5.0;
            double actualValue =c.Subtract(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
       /* [Test]
        public void TestToFailTest() // check to see if the test does fail
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 99.0;
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }*/
    }
}
