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
    public class Exercise02Test
    {
        [TestMethod]
        public void Test_SnakeCaseToTitleCase()
        {
            var exercise02 = new Exercise02();
            Assert.AreEqual(exercise02.SnakeCaseToTitleCase("snake_case"), "SnakeCase");
        }
    }
}
