using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise08
    {
        public float CalculatePi(float e)
        {
            var i = 1;
            var x = 4f;
            var pi = x;

            while(x * x >= e * e)
            {
                x *= (-i * 1f/ (i + 2));
                pi += x;
                i += 2;
            }

            return pi;
        }
    }
}
