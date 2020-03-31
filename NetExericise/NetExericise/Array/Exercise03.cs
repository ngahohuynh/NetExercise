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
            return arr.Sum(i =>
            {
                if (i % 2 == 0)
                {
                    return i;
                }
                else
                {
                    return -i;
                }
            });
        }
    }
}
