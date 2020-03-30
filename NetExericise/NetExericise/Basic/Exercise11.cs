using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise11
    {
        public int ReverseBits(int n)
        {
            var m = 0;

            while (n > 0)
            {
                m <<= 1;
                m ^= (n & 1);
                n >>= 1;
            }

            return m;
        }
    }
}
