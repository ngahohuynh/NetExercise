using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise04
    {
        public string FiboNacciLessThanN(int n)
        {
            var fiboList = new List<int>() { 1, 1 };

            var len = fiboList.Count();
            var sum = fiboList[len - 2] + fiboList[len - 1];

            while(sum <= n)
            {
                fiboList.Add(sum);
                len++;
                sum = fiboList[len - 2] + fiboList[len - 1];
            }

            return string.Join(" ", fiboList);
        }
    }
}
