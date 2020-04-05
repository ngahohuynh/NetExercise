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
    public class Exercise08Test
    {
        [TestMethod]
        public void Test_RemoveDuplicates()
        {
            var exercise08 = new Exercise08();
            Assert.AreEqual(exercise08.RemoveDuplicates("abbbbbbccccd eeffffddbc"), "abcd efdbc");
        }
    }
}
