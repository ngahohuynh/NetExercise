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
    public class Exercise10Test
    {
        [TestMethod]
        public void Test_SumOfSquareNumbers()
        {
            var exercise10 = new Exercise10();
            Assert.AreEqual(exercise10.SumOfSquareNumbers(new int[] { 1, 2, 5, 20, 16, 35, 36 }), 53);
        }
    }
}
