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
    public class Exercise06Test
    {
        [TestMethod]
        public void Test_Calculate()
        {
            var exercise06 = new Exercise06();
            Assert.AreEqual(exercise06.Calculate(12), 728);
        }
    }
}
