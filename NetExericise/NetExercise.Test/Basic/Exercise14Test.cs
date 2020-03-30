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
    public class Exercise14Test
    {
        [TestMethod]
        public void Test_CountTrailingZeros()
        {
            var exercise14 = new Exercise14();
            Assert.AreEqual(exercise14.CountTrailingZeros(10), 2);
        }
    }
}
