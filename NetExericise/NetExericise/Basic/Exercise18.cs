using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise18
    {
        readonly int[] LoopConst = { 4, 16, 37, 58, 89, 145, 42 };

        public bool IsHappyNumber(int n)
        {
            while(true)
            {
                if (LoopConst.Contains(n)) return false;
                if (n == 1) return true;

                n = SumOfSquaredDigits(n);
            }
        }

        int SumOfSquaredDigits(int n)
        {
            var sum = 0;

            while(n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }

            return sum;
        }
    }
}
