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
            var set = new HashSet<int>();
            var rand = new Random();

            while(set.Count < n)
            {
                set.Add(rand.Next(1, n + 1));
            }

            return set.ToList();
        }
    }
}
