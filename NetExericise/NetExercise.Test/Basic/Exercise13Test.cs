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
    public class Exercise13Test
    {
        [TestMethod]
        public void Test_GenerateIpAddresses()
        {
            var exercise13 = new Exercise13();
            Assert.AreEqual(exercise13.GenerateIpAddresses("128168123"),
                "1.28.168.123, 12.8.168.123, 12.81.68.123, 128.1.68.123, 128.16.8.123, 128.16.81.23, 128.168.1.23, 128.168.12.3");
            Assert.AreEqual(exercise13.GenerateIpAddresses("25525511135"), 
                "255.255.11.135, 255.255.111.35");
        }
    }
}
