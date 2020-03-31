using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise09
    {
        public List<int> GenerateIncreasingArray(int n)
        {
            var rand = new Random();
            var result = new List<int>();

            for(var i = 0; i < n; i++)
            {
                result.Add(rand.Next(1, n + 1));
            }

            result.OrderBy(x => x);

            return result;
        }
    }
}
