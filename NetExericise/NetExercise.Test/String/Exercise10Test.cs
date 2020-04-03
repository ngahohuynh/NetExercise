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
    public class Exercise10Test
    {
        [TestMethod]
        public void Test_SplitFirstAndLastName()
        {
            var exercise10 = new Exercise10();
            Assert.AreEqual(exercise10.SplitFirstAndLastName("Ho Huynh Nga"), "Ho Huynh, Nga");
        }
    }
}
