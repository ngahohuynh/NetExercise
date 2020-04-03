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
    public class Exercise01Test
    {
        [TestMethod]
        public void Test_TitleCaseToSnakeCase()
        {
            var exercise01 = new Exercise01();
            Assert.AreEqual(exercise01.TitleCaseToSnakeCase("MyProgram"), "my_program");
        }
    }
}
