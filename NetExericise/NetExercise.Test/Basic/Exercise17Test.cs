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
    public class Exercise17Test
    {
        [TestMethod]
        public void Test_FindNumber()
        {
            var exercise17 = new Exercise17();
            Assert.AreEqual(exercise17.FindNumber(1000), 10301);
            Assert.AreEqual(exercise17.FindNumber(50000), 70207);
        }
    }
}
