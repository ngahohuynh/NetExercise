using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetExericise.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExercise.Test.Basic
{
    [TestClass]
    public class Exercise03Test
    {
        [TestMethod]
        public void Test_PrimeFactors()
        {
            var exercise03 = new Exercise03();
            Assert.AreEqual(exercise03.PrimeFactors(600), "2 * 2 * 2 * 3 * 5 * 5");
        }

        [TestMethod]
        public void Test_PrimeFactors_PrimeNumbers()
        {
            var exercise03 = new Exercise03();
            Assert.AreEqual(exercise03.PrimeFactors(8191), "8191");
        }
    }
}
