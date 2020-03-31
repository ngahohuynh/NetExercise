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
    public class Exercise02Test
    {
        [TestMethod]
        public void Test_MaxTripletSum()
        {
            var exercise02 = new Exercise02();
            Assert.AreEqual(exercise02.MaxTripletSum(new int[] { 12, 20, 40, 1, 5, 10, 30, 20 }), 90);
        }
    }
}
