using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscrPerc.Tests
{
    [TestClass]
    public class DiscrimProcTests
    {
        static double[] factor;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            factor = new double[] { 1, -70, 600, 0, 2, 3 };
        }

        [TestMethod]
        public void GetQuadEquat_DLessThan0_returnEmptyList()
        {
            double[] actual = DiscrimProc.GetQuadEquat(factor[0], factor[4], factor[5]);
            CollectionAssert.AreEqual(actual, new double[] { double.NaN, double.NaN });
        }

        [TestMethod]
        public void GetQuadEquat_DEquals0_return0()
        {
            double[] actual = DiscrimProc.GetQuadEquat(factor[0], factor[3], factor[3]);
            CollectionAssert.AreEquivalent(actual, new double[] { 0, 0 });
        }

        [TestMethod]
        public void GetQuadEquat_DMoreThan0_return60and10()
        {
            double[] actual = DiscrimProc.GetQuadEquat(factor[0], factor[1], factor[2]);
            CollectionAssert.IsSubsetOf(actual, new double[] { 60, 10 });
        }

        [TestMethod]
        public void CalculPercent_25of240_return25()
        {
            double expected = 60;
            double actual = DiscrimProc.CalculPercent(240, 25);
            double delta = 0.5;
            Assert.AreEqual(actual, expected, delta);
        }
    }
}
