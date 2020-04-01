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
    public class Exercise03Test
    {
        [TestMethod]
        public void Test_ReverseString()
        {
            var exercise03 = new Exercise03();
            Assert.AreEqual(exercise03.ReverseString("abcdefg"), "gfedcba");
        }
    }
}
