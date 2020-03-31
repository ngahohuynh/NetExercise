using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise17
    {
        public int FindNumber(int n)
        {
            while (true)
            {
                var m = n++;

                if (IsPalindrome(m) && IsPrime(m))
                    return m;
            }
        }

        bool IsPalindrome(int n)
        {
            var charArr = n.ToString().ToCharArray();
            System.Array.Reverse(charArr);
            return n == Convert.ToInt32(new string(charArr));
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
