using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise12
    {
        public bool IsPalindrome(int n)
        {
            var temp = n;
            var m = 0;

            while (temp > 0)
            {
                m = m * 10 + (temp % 10);
                temp /= 10;
            }

            return m == n;
        }
    }
}
