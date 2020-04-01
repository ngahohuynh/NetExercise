using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise05
    {
        public string LongestIncreasingSubArray(int[] arr)
        {
            var len = 1;
            var max = 1;
            var index = 0;

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                    len++;
                else
                {
                    if (max < len)
                    {
                        max = len;
                        index = i - max;
                    }
                    len = 1;
                }
            }

            if (max < len)
            {
                max = len;
                index = arr.Length - max;
            }

            var result = arr.Skip(index).Take(max);

            return string.Join(" ", result);
        }
    }
}
