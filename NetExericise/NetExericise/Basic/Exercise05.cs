using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise05
    {
        public string ArmstrongNumbers(int m)
        {
            var list = new List<int>();
            var begin = (int)Math.Pow(10, m - 1);

            foreach(var n in Enumerable.Range(begin, 9 * begin))
            {
                if (IsArmstrongNumber(n, m)) list.Add(n);
            }

            return string.Join(" ", list);
        }

        bool IsArmstrongNumber(int n, int m)
        {
            var temp = n;
            var sum = 0;

            while(temp > 0)
            {
                sum += (int)Math.Pow(temp % 10, m);
                temp /= 10;
            }

            return sum == n;
        }
    }
}
