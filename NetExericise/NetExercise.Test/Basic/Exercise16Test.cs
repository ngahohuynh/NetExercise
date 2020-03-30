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
    public class Exercise16Test
    {
        [TestMethod]
        public void Test_CheckNumber()
        {
            var exercise16 = new Exercise16();
            Assert.AreEqual(exercise16.CheckNumber(15), true);
        }
    }
}
