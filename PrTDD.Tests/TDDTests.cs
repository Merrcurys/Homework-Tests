using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace PrTDD.Tests
{
    [TestClass]
    public class TDDTests
    {
        [TestMethod]
        public void Short_string_areturn()
        {
            TDD tdd = new TDD();
            StringAssert.StartsWith(tdd.Short("A dogs!"), "A");
        }

        [TestMethod]
        public void WordCount_string_4return()
        {
            TDD tdd = new TDD();
            Assert.IsFalse(tdd.WordCount("A dogs very biggest!") != 4);
        }

        [TestMethod]
        public void CharCount_string_5return()
        {
            TDD tdd = new TDD();
            Assert.IsNotNull(tdd.CharCount("epple"));
        }

        [TestMethod]
        public void NineChar_string_spacereturn()
        {
            TDD tdd = new TDD();
            StringAssert.Contains(tdd.NineChar("Jeg ikke elsker epple."), " ");
        }

        [TestMethod]
        public void NumberCount_string_4return()
        {
            TDD tdd = new TDD();

            Assert.AreEqual(4, tdd.NumberCount("Jeg ikke elsker 1234 epple."));
        }

        [TestMethod]
        public void TwinNumber_string_4return()
        {
            TDD tdd = new TDD();

            Assert.IsTrue(tdd.TwinNumber("Jeg ikke elsker 1234 epple.") == 4);
        }

        [TestMethod]
        public void AmCount_string_3return()
        {
            TDD tdd = new TDD();
            StringAssert.Matches(tdd.AmCount("амамамам").ToString(), new Regex(@"4"));

        }
    }
}
