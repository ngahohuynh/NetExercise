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
    public class Exercise11Test
    {
        [TestMethod]
        public void Test_ReverseBits()
        {
            var exercise11 = new Exercise11();
            Assert.AreEqual(exercise11.ReverseBits(11), 13);
            Assert.AreEqual(exercise11.ReverseBits(10), 5);
        }
    }
}
