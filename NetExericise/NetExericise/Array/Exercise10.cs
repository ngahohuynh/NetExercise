using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise10
    {
        public int SumOfSquareNumbers(int[] arr)
        {
            return arr.Where(IsPerfectSquare).Sum();
        }

        bool IsPerfectSquare(int n)
        {
            for(var i = 1; i * i <= n; i++)
            {
                if (n % i == 0 && n / i == i)
                    return true;
            }
            return false;
        }
    }
}
