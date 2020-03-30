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
    public class Exercise07Test
    {
        [TestMethod]
        public void Test_Factorial()
        {
            var exercise07 = new Exercise07();
            Assert.AreEqual(exercise07.Factorial(10), 3628800);
            Assert.AreEqual(exercise07.Factorial(12), 479001600);
        }
    }
}
