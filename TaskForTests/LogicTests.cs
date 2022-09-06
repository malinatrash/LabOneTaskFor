using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskFor;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFor.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void SquareIsEqualNine()
        {
            var number = 3;
            var answer = Logic.Calculate(number);
            Assert.AreEqual(9, answer);
        }

        [TestMethod()]
        public void SquareIsEqualNull()
        {
            var number = 0;
            var answer = Logic.Calculate(number);
            Assert.AreEqual(0, answer);
        }

        [TestMethod()]
        public void SquareIsEqualOne()
        {
            var number = 1;
            var answer = Logic.Calculate(number);
            Assert.AreEqual(1, answer);
        }
    }
}