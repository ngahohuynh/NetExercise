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

            double left, right, mid;

            if (n < 1)
            {
                left = 0;
                right = 1;
            }

            else
            {
                left = 0;
                right = n;
            }

            do
            {
                mid = (left + right) / 2;
                if (Func(mid, n) == 0) break;
                if (Func(left, n) * Func(mid, n) < 0) right = mid;
                else left = mid;
            } while ((left - right) * (left - right) > e * e);

            return mid;
        }

        double Func(double x, double n)
        {
            return x * x * x - n;
        }
    }
}
