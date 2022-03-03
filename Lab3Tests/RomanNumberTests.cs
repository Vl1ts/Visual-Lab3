using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
        }
        [TestMethod()]
        public void RomanNumberTest2()
        {
            Assert.IsNotNull(new RomanNumber(1));
        }
        [TestMethod()]
        public void RomanNumberTest3()
        {
            Assert.IsNotNull(new RomanNumber(150));
        }
        [TestMethod()]
        public void RomanNumberTest4()
        {
            Assert.IsNotNull(new RomanNumber(3999));
        }
        [TestMethod()]
        public void RomanNumberTest5()
        {
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var roman = new RomanNumber(1);
            string expected = "I";

            Assert.AreEqual(expected, roman.ToString());
        }
        [TestMethod()]
        public void ToStringTest2()
        {
            var roman = new RomanNumber(136);
            string expected = "CXXXVI";

            Assert.AreEqual(expected, roman.ToString());
        }
        [TestMethod()]
        public void ToStringTest3()
        {
            var roman = new RomanNumber(3999);
            string expected = "MMMCMXCIX";

            Assert.AreEqual(expected, roman.ToString());
        }

        [TestMethod()]
        public void CloneTest()
        {
            var roman = new RomanNumber(5);
            Assert.IsNotNull(roman.Clone());
        }
        [TestMethod()]
        public void CloneTest2()
        {
            var roman = new RomanNumber(5);
            var romanClone = roman.Clone();

            Assert.IsTrue(roman.CompareTo(romanClone) == 0);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var romanFirst = new RomanNumber(10);
            var romanSecond = new RomanNumber(541);

            Assert.IsTrue(romanFirst.CompareTo(romanSecond) < 0);
        }
        [TestMethod()]
        public void CompareToTest2()
        {
            var romanFirst = new RomanNumber(3999);
            var romanSecond = new RomanNumber(1);

            Assert.IsTrue(romanFirst.CompareTo(romanSecond) > 0);
        }
        [TestMethod()]
        public void CompareToTest3()
        {
            var romanFirst = new RomanNumber(81);
            var romanSecond = new RomanNumber(81);

            Assert.IsTrue(romanFirst.CompareTo(romanSecond) == 0);
        }

        [TestMethod()]
        public void AddTest()
        {
            var romanFirst = new RomanNumber(81);
            var romanSecond = new RomanNumber(193);
            var romanResult = new RomanNumber(274);

            Assert.IsTrue(romanResult.CompareTo(romanFirst + romanSecond) == 0);
        }
        [TestMethod()]
        public void AddTest2()
        {
            var romanFirst = new RomanNumber(3999);
            var romanSecond = new RomanNumber(193);

            Assert.ThrowsException<RomanNumberException>(() => romanFirst + romanSecond);
        }
        [TestMethod()]
        public void AddTest3()
        {
            var romanFirst = new RomanNumber(81);
            RomanNumber? romanSecond = null;

            Assert.ThrowsException<RomanNumberException>(() => romanFirst + romanSecond);
        }

        [TestMethod()]
        public void SubTest()
        {
            var romanFirst = new RomanNumber(3293);
            var romanSecond = new RomanNumber(841);
            var romanResult = new RomanNumber(2452);

            Assert.IsTrue(romanResult.CompareTo(romanFirst - romanSecond) == 0);
        }
        [TestMethod()]
        public void SubTest2()
        {
            var romanFirst = new RomanNumber(81);
            var romanSecond = new RomanNumber(193);

            Assert.ThrowsException<RomanNumberException>(() => romanFirst - romanSecond);
        }
        [TestMethod()]
        public void SubTest3()
        {
            var romanFirst = new RomanNumber(81);
            RomanNumber? romanSecond = null;

            Assert.ThrowsException<RomanNumberException>(() => romanFirst - romanSecond);
        }

        [TestMethod()]
        public void MulTest()
        {
            var romanFirst = new RomanNumber(97);
            var romanSecond = new RomanNumber(5);
            var romanResult = new RomanNumber(485);

            Assert.IsTrue(romanResult.CompareTo(romanFirst * romanSecond) == 0);
        }
        [TestMethod()]
        public void MulTest2()
        {
            var romanFirst = new RomanNumber(197);
            var romanSecond = new RomanNumber(1);
            var romanResult = new RomanNumber(197);

            Assert.IsTrue(romanResult.CompareTo(romanFirst * romanSecond) == 0);
        }
        [TestMethod()]
        public void MulTest3()
        {
            var romanFirst = new RomanNumber(189);
            var romanSecond = new RomanNumber(43);

            Assert.ThrowsException<RomanNumberException>(() => romanFirst * romanSecond);
        }
        [TestMethod()]
        public void MulTest4()
        {
            var romanFirst = new RomanNumber(97);
            RomanNumber? romanSecond = null;

            Assert.ThrowsException<RomanNumberException>(() => romanFirst * romanSecond);
        }

        [TestMethod()]
        public void DivTest()
        {
            var romanFirst = new RomanNumber(1892);
            var romanSecond = new RomanNumber(4);
            var romanResult = new RomanNumber(473);

            Assert.IsTrue(romanResult.CompareTo(romanFirst / romanSecond) == 0);
        }
        [TestMethod()]
        public void DivTest2()
        {
            var romanFirst = new RomanNumber(2001);
            var romanSecond = new RomanNumber(1);
            var romanResult = new RomanNumber(2001);

            Assert.IsTrue(romanResult.CompareTo(romanFirst / romanSecond) == 0);
        }
        [TestMethod()]
        public void DivTest3()
        {
            var romanFirst = new RomanNumber(2871);
            var romanSecond = new RomanNumber(2871);
            var romanResult = new RomanNumber(1);

            Assert.IsTrue(romanResult.CompareTo(romanFirst / romanSecond) == 0);
        }
        [TestMethod()]
        public void DivTest4()
        {
            var romanFirst = new RomanNumber(3799);
            var romanSecond = new RomanNumber(53);
            var romanResult = new RomanNumber(71);

            Assert.IsTrue(romanResult.CompareTo(romanFirst / romanSecond) == 0);
        }
        [TestMethod()]
        public void DivTest5()
        {
            var romanFirst = new RomanNumber(1);
            var romanSecond = new RomanNumber(20);

            Assert.ThrowsException<RomanNumberException>(() => romanFirst / romanSecond);
        }
        [TestMethod()]
        public void DivTest6()
        {
            var romanFirst = new RomanNumber(145);
            var romanSecond = new RomanNumber(146);

            Assert.ThrowsException<RomanNumberException>(() => romanFirst / romanSecond);
        }
        [TestMethod()]
        public void DivTest7()
        {
            var romanFirst = new RomanNumber(97);
            RomanNumber? romanSecond = null;

            Assert.ThrowsException<RomanNumberException>(() => romanFirst / romanSecond);
        }
    }
}