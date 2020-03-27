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
    public class Exercise04Test
    {
        [TestMethod]
        public void Test_FiboNacciLessThanN()
        {
            var exercise04 = new Exercise04();
            Assert.AreEqual(exercise04.FiboNacciLessThanN(15), "1 1 2 3 5 8 13");
            Assert.AreEqual(exercise04.FiboNacciLessThanN(200), "1 1 2 3 5 8 13 21 34 55 89 144");
        }
    }
}
