using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise14
    {
        public int CountTrailingZeros(int n)
        {
            var count = 0;
            for (var i = 5; i <= n; i *= 5)
            {
                count += n / i;
            }
            return count;
        }
    }
}
