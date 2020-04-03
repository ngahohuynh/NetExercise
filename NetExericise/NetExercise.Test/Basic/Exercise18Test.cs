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
    public class Exercise18Test
    {
        [TestMethod]
        public void Test_IsHappyNumber()
        {
            var exercise18 = new Exercise18();
            Assert.AreEqual(exercise18.IsHappyNumber(17), false);
            Assert.AreEqual(exercise18.IsHappyNumber(19), true);
        }
    }
}
