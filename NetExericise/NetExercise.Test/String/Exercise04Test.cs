using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetExericise.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExercise.Test.String
{
    [TestClass]
    public class Exercise04Test
    {
        [TestMethod]
        public void Test_SumOfNumbers()
        {
            var exercise04 = new Exercise04();
            Assert.AreEqual(exercise04.SumOfNumbers("abc 123 def 33 mn 3.221"), 380);
        }
    }
}
