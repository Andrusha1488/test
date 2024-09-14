using Microsoft.VisualStudio.TestTools.UnitTesting;
using test1practic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1practic.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void TestPassword_Empty_0()
        {
            Assert.AreEqual(5, Class1.PasswordVerify(""));
        }
        [TestMethod()]
        public void TestPassword_Numbers_1()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("1"));
        }
        [TestMethod()]

        public void TestPassword_Letters_2()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("1prac"));
        }
        [TestMethod()]

        public void TestPassword_BigLetters_3()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("1Prac"));
        }
        [TestMethod()]

        public void TestPassword_Length_6()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("Practic"));
        }

        public void TestPassword_Special_4()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("1Prac-"));
        }
        [TestMethod()]

        public void TestPassword_Final_5()
        {
            Assert.AreEqual(5, Class1.PasswordVerify("1Practic!123"));
        }
    }
}