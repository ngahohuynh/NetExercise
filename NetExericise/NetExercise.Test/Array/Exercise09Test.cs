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
    public class Exercise09Test
    {
        [TestMethod]
        public void Test_GenerateIncreasingArray()
        {
            var exercise09 = new Exercise09();
            var list = exercise09.GenerateIncreasingArray(20);
            Assert.IsTrue(list.All(x => x >= 1 && x <= 20));
        }
    }
}
