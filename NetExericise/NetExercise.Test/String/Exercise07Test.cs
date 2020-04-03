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
    public class Exercise07Test
    {
        [TestMethod]
        public void Test_ConvertString()
        {
            var exercise07 = new Exercise07();
            Assert.AreEqual(exercise07.ConvertString("abc4e6fd3"), "abcccceeeeeefddd");
            Assert.AreEqual(exercise07.ConvertString("ab13c"), "abbbbbbbbbbbbbc");
        }
    }
}
