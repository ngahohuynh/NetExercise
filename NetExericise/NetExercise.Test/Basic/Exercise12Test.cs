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
    public class Exercise12Test
    {
        [TestMethod]
        public void Test_IsPalindrome()
        {
            var exercise12 = new Exercise12();
            Assert.AreEqual(exercise12.IsPalindrome(12321), true);
            Assert.AreEqual(exercise12.IsPalindrome(101010), false);
        }
    }
}
