using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrTDD.Tests
{
    [TestClass]
    public class TDDTests
    {
        [TestMethod]
        public void Short_string_areturn()
        {
            TDD tdd = new TDD();
            Assert.AreEqual("A", tdd.Short("A dogs!"));
        }

        [TestMethod]
        public void WordCount_string_4return()
        {
            TDD tdd = new TDD();
            Assert.AreEqual(4, tdd.WordCount("A dogs very biggest!"));
        }

        [TestMethod]
        public void CharCount_string_5return()
        {
            TDD tdd = new TDD();
            Assert.IsNotNull(tdd.CharCount("epple"));
            Assert.AreEqual(5, tdd.CharCount("epple"));
        }

        [TestMethod]
        public void NineChar_string_spacereturn()
        {
            TDD tdd = new TDD();
            Assert.AreEqual(" ", tdd.NineChar("Jeg ikke elsker epple."));
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
            Assert.IsNotNull(tdd.TwinNumber("Jeg ikke elsker 1234 epple."));
            Assert.IsTrue(tdd.TwinNumber("Jeg ikke elsker 1234 epple.") == 4);
        }

        [TestMethod]
        public void AmCount_string_3return()
        {
            TDD tdd = new TDD();
            Assert.IsTrue(tdd.AmCount("амамамам") == 4);
        }
    }
}
