using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise04
    {
        public int SumOfPrimeNumbers(int[] arr)
        {
            return arr.Sum(i => {
                if (IsPrime(i))
                {
                    return i;
                }
                return 0;
            });
        }

        bool IsPrime(int n)
        {
            if (n <= 1) return false;

            for (var i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
