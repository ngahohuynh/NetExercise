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
    public class Exercise09Test
    {
        [TestMethod]
        public void Test_CheckBarcode()
        {
            var exercise09 = new Exercise09();
            Assert.AreEqual(exercise09.CheckBarcode("8938505974194"), true);
        }
    }
}
