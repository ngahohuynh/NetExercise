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
    public class Exercise08Test
    {
        [TestMethod]
        public void Test_CountNumbers()
        {
            var exercise08 = new Exercise08();
            Assert.AreEqual(exercise08.CountNumbers(new int[] { 1, 2, 5, 7, 12, 20, 30, 33 }), 2);
        }
    }
}
