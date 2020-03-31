using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise03
    {
        public int OddEvenDifference(int[] arr)
        {
            return arr.Sum(x => (1 - 2 * (x % 2)) * x);
        }
    }
}
