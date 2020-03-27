using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise07
    {
        public int Factorial(int n)
        {
            var list = Enumerable.Range(1, n).ToList();

            return list.Aggregate<int, int>(1, (factorial, num) => factorial *= num);
        }
    }
}
