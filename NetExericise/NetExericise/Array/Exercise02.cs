using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise02
    {
        public int MaxTripletSum(int[] arr)
        {
            return arr.OrderByDescending(num => num).Take(3).Sum();
        }
    }
}
