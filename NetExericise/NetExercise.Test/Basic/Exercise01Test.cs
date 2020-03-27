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
    public class Exercise01Test
    {
        [TestMethod]
        public void Test_Ucln()
        {
            var exercise01 = new Exercise01();
            Assert.AreEqual(exercise01.Ucln(6, 8), 2);
            Assert.AreEqual(exercise01.Ucln(30, 48), 6);
        }

        [TestMethod]
        public void Test_Bcnn()
        {
            var exercise01 = new Exercise01();
            Assert.AreEqual(exercise01.Bcnn(6, 8), 24);
            Assert.AreEqual(exercise01.Bcnn(30, 48), 240);
        }

    }
}
