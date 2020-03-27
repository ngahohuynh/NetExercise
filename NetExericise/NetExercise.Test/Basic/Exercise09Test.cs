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
    public class Exercise09Test
    {
        [TestMethod]
        public void Test_CalculateSqrt()
        {
            var exercise09 = new Exercise09();
            Assert.AreEqual(exercise09.CalculateSqrt(9, 0.01), 3);
            Assert.AreEqual(exercise09.CalculateSqrt(2, 0.0001), Math.Sqrt(2), 0.0001);
        }

    }
}
