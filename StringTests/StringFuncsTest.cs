using System;
using HouseWorkFive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTests
{
    [TestClass]
    public class StringFuncsTest
    {
        [DataTestMethod]
        [DataRow("I love it!", 1)]
        [DataRow("Hello World, everyone!", 5)]
        [DataRow("Hey, bring it to me", 2)]
        [DataRow("C", 1)]
        public void TestShortestString(string str, int res)
        {
            Assert.AreEqual(res, StringFunction.ShortestWord(str));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestShortestStringExg(string str)
        {
            StringFunction.ShortestWord(str);
        }

        [DataTestMethod]
        [DataRow(new string[] { "I", "love", "it!" }, 4, new string[] { "I", "l$", "it!" })]
        [DataRow(new string[] { "Hello", "World", "everyone!" }, 5, new string[] { "He$", "Wo$", "everyone!" })]
        [DataRow(new string[] { "Hey", "bring", "it", "to", "me" }, 3, new string[] { "$", "bring", "it", "to", "me" })]
        [DataRow(new string[] { }, 3, new string[] { })]
        public void TestReplaceLast3(string[] str, int length, string[] res)
        {
            CollectionAssert.AreEqual(res, StringFunction.ReplaceLast3(str,length));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestReplaceLast3ExLength()
        {
            StringFunction.ReplaceLast3(new string[] { }, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestReplaceLast3ExNull()
        {
            StringFunction.ReplaceLast3(new string[] { null }, 4);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("ABC", "ABC")]
        [DataRow("Hello", "Helo")]
        [DataRow("Its ab big world", "Its abigworld")]
        public void TestDeleteCopy(string init, string expected)
        {
            Assert.AreEqual(expected, StringFunction.DeleteCopy(init));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestDeleteCopyEx()
        {
            StringFunction.DeleteCopy(null);
        }

        [DataTestMethod]
        [DataRow("", 0)]
        [DataRow("  ", 0)]
        [DataRow("One", 1)]
        [DataRow("One two", 2)]
        [DataRow("One two,three", 3)]
        public void TestwordCount(string init, int expected)
        {
            Assert.AreEqual(expected, StringFunction.WordsCount(init));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestWordCountEx()
        {
            StringFunction.WordsCount(null);
        }

        [DataTestMethod]
        [DataRow("", 0, 0, "")]
        [DataRow("  ", 0, 2, "")]
        [DataRow("One", 1, 1, "Oe")]
        [DataRow("One two", 2, 3, "Onwo")]
        [DataRow("One two three", 4, 1, "One wo three")]
        public void TestMyDelete(string init, int pos,
            int length, string expected)
        {
            Assert.AreEqual(expected, StringFunction.MyDelete(init, pos, length));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMyDeleteExNull()
        {
            StringFunction.MyDelete(null, 0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMyDeleteEx()
        {
            StringFunction.MyDelete("Hello", 3, 5);
        }

        [DataTestMethod]
        [DataRow("Hello", "olleH")]
        [DataRow("My Day", "yaD yM")]
        public void TestReverseString(string init, string expected)
        {
            Assert.AreEqual(expected, StringFunction.ReverseString(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestReverseStringEx()
        {
            StringFunction.ReverseString(null);
        }

        [DataTestMethod]
        [DataRow("Test", "")]
        [DataRow("Test method", "Test")]
        [DataRow("Test new method", "Test new")]
        public void TestDeleteLastWord(string init, string expected)
        {
            Assert.AreEqual(expected, StringFunction.DeleteLastWord(init));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestDeleteLastWordEx()
        {
            StringFunction.DeleteLastWord(null);
        }

        [DataTestMethod]
        [DataRow("Hello,world!", "Hello, world!")]
        [DataRow("Hello, world!", "Hello, world!")]
        [DataRow("Hello,world!Its.Ok", "Hello, world! Its. Ok")]
        public void TestAddSpaces(string init, string expected)
        {
            Assert.AreEqual(expected, StringFunction.AddSpaces(init));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddSpacesEx()
        {
            StringFunction.AddSpaces(null);
        }
    }
}
