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
   public class Exercise15Test
    {
        [TestMethod]
        public void Test_CountDigits()
        {
            var exercise15 = new Exercise15();
            Assert.AreEqual(exercise15.CounDigits(10), 7);
        }
    }
}
