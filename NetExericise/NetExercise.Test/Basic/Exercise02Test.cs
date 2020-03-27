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
    public class Exercise02Test
    {
        [TestMethod]
        public void Test_SumOfDigits()
        {
            var exercise02 = new Exercise02();
            Assert.AreEqual(exercise02.SumOfDigits(2324142), 18);
            Assert.AreEqual(exercise02.SumOfDigits(8799), 33);
        }
    }
}
