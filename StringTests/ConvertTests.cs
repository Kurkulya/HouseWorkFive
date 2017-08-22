using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseWorkFive;

namespace StringTests
{
    [TestClass]
    public class ConvertTests
    {
        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(12345, "12345")]
        [DataRow(-12, "-12")]
        public void TestIntToStr(int num, string exp)
        {
            Assert.AreEqual(exp, MyConvert.IntToStr(num));
        }

        [DataTestMethod]
        [DataRow(1.5, "1.5")]
        [DataRow(0, "0")]
        [DataRow(0.27, "0.27")]
        public void TestDoubleToString(double num, string exp)
        {
            Assert.AreEqual(exp, MyConvert.DoubleToString(num));
        }

        [DataTestMethod]
        [DataRow("0", 0)]
        [DataRow("12345", 12345)]
        public void TestStrToInt(string str, int exp)
        {
            Assert.AreEqual(exp, MyConvert.StrToInt(str));
        }

        [DataTestMethod]
        [DataRow("-12")]
        [DataRow("1.2")]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestStrToIntEx(string str)
        {
            MyConvert.StrToInt(str);
        }

        [DataTestMethod]
        [DataRow("1.5", 1.5)]
        [DataRow("0", 0)]
        [DataRow("0.27", 0.27)]
        public void TestStrToDouble(string str, double exp)
        {
            Assert.AreEqual(exp, MyConvert.StrToDouble(str), 0.0001);
        }

        [DataTestMethod]
        [DataRow("-1.5")]
        [DataRow("12.3abc")]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestStrToDoubleEx(string str)
        {
            MyConvert.StrToDouble(str);
        }
    }
}
