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
    public class Exercise08Test
    {
        [TestMethod]
        public void Test_CalculatePi()
        {
            var exercise08 = new Exercise08();
            Assert.AreEqual(exercise08.CalculatePi(0.0001f), Math.PI, 0.0001);
        }
    }
}
