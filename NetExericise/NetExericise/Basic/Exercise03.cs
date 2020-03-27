using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise03
    {
        public string PrimeFactors(int n)
        {
            var numbers = new List<int>();

            int i = 2;

            while(n > 1)
            {
                if (n % i == 0)
                {
                    numbers.Add(i);
                    n /= i;
                }
                else i++;
            }

            return string.Join(" * ", numbers);
        }

    }
}
