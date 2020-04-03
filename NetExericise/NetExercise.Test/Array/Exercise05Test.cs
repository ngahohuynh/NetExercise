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
    public class Exercise05Test
    {
        [TestMethod]
        public void Test_LongestIncreasingSubArray()
        {
            var exercise05 = new Exercise05();
            Assert.AreEqual(exercise05.LongestIncreasingSubArray(new int[] { 5, 6, 3, 5, 7, 8, 9, 1, 2 }), "3 5 7 8 9");
        }
    }
}
