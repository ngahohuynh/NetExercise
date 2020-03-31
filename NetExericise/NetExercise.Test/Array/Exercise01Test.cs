using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetExericise.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExercise.Test.Array
{
    [TestClass]
    public class Exercise01Test
    {
        [TestMethod]
        public void Test_NumbersAppearTwice()
        {
            var exercise01 = new Exercise01();
            Assert.AreEqual(exercise01.NumbersAppearTwice(
                new int[] { 1, 1, 2, 2, 3, 2, 5, 4, 4, 5, 4, 6, 4 }), "2 4");
        }
    }
}
