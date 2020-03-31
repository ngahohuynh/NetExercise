using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise06
    {
        public int BinarySearch(int[] arr, int n)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var i = left + (right - left) / 2;
                if (arr[i] == n)
                {
                    return i;
                }

                if (arr[i] < n)
                {
                    left = i + 1;
                }
                else
                {
                    right = i - 1;
                }
            }

            return -1;
        }
    }
}
