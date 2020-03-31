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
            var sortedArr = arr.OrderByDescending(num => num).ToArray();
            return sortedArr[0] + sortedArr[1] + sortedArr[2];
        }
    }
}
