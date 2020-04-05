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
    public class Exercise05Test
    {
        [TestMethod]
        public void Test_IsPalindrome()
        {
            var exercise05 = new Exercise05();
            Assert.AreEqual(exercise05.IsPalindrome("abcdcba"), true);
            Assert.AreEqual(exercise05.IsPalindrome("abcd"), false);
        }
    }
}
