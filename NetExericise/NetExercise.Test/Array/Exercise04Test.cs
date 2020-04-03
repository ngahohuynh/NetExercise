using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetExericise.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExercise.Test.Array
{
    [TestClass]
    public class Exercise04Test
    {
        [TestMethod]
        public void Test_SumOfPrimeNumbers()
        {
            var exercise04 = new Exercise04();
            Assert.AreEqual(exercise04.SumOfPrimeNumbers(new int[] { 1, 0, 2, 3, 5, 12, 35, 500, 10301 }), 10311);
        }
    }
}
