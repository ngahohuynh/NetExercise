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
    public class Exercise05Test
    {
        [TestMethod]
        public void Test_ArmstrongNumbers()
        {
            var exercise05 = new Exercise05();
            Assert.AreEqual(exercise05.ArmstrongNumbers(3), "153 370 371 407");
            Assert.AreEqual(exercise05.ArmstrongNumbers(4), "1634 8208 9474");
            Assert.AreEqual(exercise05.ArmstrongNumbers(5), "54748 92727 93084");
        }

    }
}
