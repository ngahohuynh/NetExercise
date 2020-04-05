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
    public class Exercise06Test
    {
        [TestMethod]
        public void Test_ConvertString()
        {
            var exercise06 = new Exercise06();
            Assert.AreEqual(exercise06.ConvertString("abcccceeeeeefddd"), "abc4e6fd3");
            Assert.AreEqual(exercise06.ConvertString("abbbbbbbbbbbbbc"), "ab13c");
        }
    }
}
