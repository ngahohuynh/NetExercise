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
    public class Exercise07Test
    {
        [TestMethod]
        public void Test_ChunkArray()
        {
            var exercise07 = new Exercise07();
            var testResult = exercise07.ChunkArray(new int[] { 5, 6, 3, 5, 7, 8, 9, 1, 2 }, 4);

            Assert.AreEqual(testResult.Count(), 3);
            CollectionAssert.AreEqual(testResult[0], new List<int> { 5, 6, 3, 5 });
            CollectionAssert.AreEqual(testResult[2], new List<int> { 2 });
        }
    }
}
