using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void Cheking_checkpassword_1ballreturn()
        {
            // arrange
            string password = "1";
            int expected = 1;
            // act
            Password pass = new Password();
            int actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Cheking_checkpassword_2ballreturn()
        {
            // arrange
            string password = "1a";
            int expected = 2;
            // act
            Password pass = new Password();
            int actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Cheking_checkpassword_3ballreturn()
        {
            // arrange
            string password = "1aB";
            int expected = 3;
            // act
            Password pass = new Password();
            int actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Cheking_checkpassword_4ballreturn()
        {
            // arrange
            string password = "1aB#";
            int expected = 4;
            // act
            Password pass = new Password();
            int actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Cheking_checkpassword_5ballreturn()
        {
            // arrange
            string password = "1aB#hskdldk6@";
            int expected = 5;
            // act
            Password pass = new Password();
            double actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Cheking_checkpassword_0ballreturn()
        {
            // arrange
            string password = "";
            int expected = 0;
            // act
            Password pass = new Password();
            int actal = pass.Cheking(password);
            // assert
            Assert.AreEqual(expected, actal);
        }
    }
}
