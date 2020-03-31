using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise08
    {
        public int CountNumbers(int[] arr)
        {
            //return arr.Count(x => x % 3 == 0 && x % 5 != 0);
            return arr.Where(x => x % 3 == 0 && x % 5 != 0).Count();
        }
    }
}
