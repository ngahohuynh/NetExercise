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
    public class Exercise10Test
    {
        [TestMethod]
        public void Test_CalculateCubeRoot()
        {
            var exercise10 = new Exercise10();
            Assert.AreEqual(exercise10.CalculateCubeRoot(27, 0.001), 3, 0.001);
            Assert.AreEqual(exercise10.CalculateCubeRoot(2, 0.0001), Math.Pow(2, 1d / 3), 0.0001);
        }
    }
}
