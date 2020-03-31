using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise10
    {
        public int SumOfSquareNumbers(int[] arr)
        {
            return arr.Where(x => IsPerfectSquare(x)).Sum();
        }

        bool IsPerfectSquare(int x)
        {
            return Math.Sqrt(x) - Math.Floor(Math.Sqrt(x)) == 0;
        }
    }
}
