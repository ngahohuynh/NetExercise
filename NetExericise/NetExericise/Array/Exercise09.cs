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
            return Enumerable.Range(1, n).ToList();
        }
    }
}
