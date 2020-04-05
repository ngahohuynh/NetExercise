using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise09
    {
        public List<int> GenerateArray(int n)
        {
            var random = new Random();

            return Enumerable.Range(1, n).OrderBy(x => random.Next(100)).ToList();
        }
    }
}
