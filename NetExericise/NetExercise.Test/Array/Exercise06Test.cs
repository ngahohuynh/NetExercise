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
    public class Exercise06Test
    {
        [TestMethod]
        public void Test_BinarySearch()
        {
            var exercise06 = new Exercise06();
            Assert.AreEqual(exercise06.BinarySearch(new int[] { 1, 2, 5, 7, 12, 20, 35 }, 5), 2);
        }
    }
}
