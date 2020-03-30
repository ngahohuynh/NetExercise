using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise10
    {
        public double CalculateCubeRoot(double n, double e)
        {
            if (n == 1) return 1;

            var left = 0d;
            var right = (n < 1) ? 1d : n;

            do
            {
                var mid = (left + right) / 2;
                if (mid * mid * mid > n) right = mid;
                else left = mid;
            } while (right - left > e);

            return (left + right) / 2;
        }
    }
}
