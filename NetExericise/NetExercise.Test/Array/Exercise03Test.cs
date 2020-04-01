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
    public class Exercise03Test
    {
        [TestMethod]
        public void Test_OddEvenDifference()
        {
            var exercise03 = new Exercise03();
            Assert.AreEqual(exercise03.OddEvenDifference(new int[] { 1, 1, 2, 4, 3, 5, 2 }), -2);
        }
    }
}
