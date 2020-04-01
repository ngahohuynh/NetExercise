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
        public void Test_GenerateArray()
        {
            var exercise09 = new Exercise09();
            CollectionAssert.AreEqual(exercise09.GenerateArray(10), new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }
    }
}
