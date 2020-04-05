using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise07
    {
        public List<List<int>> ChunkArray(int[] arr, int n)
        {
            return Enumerable.Range(0, arr.Length)
                .GroupBy(x => x / n)
                .Select(x => arr.Skip(x.Key * n).Take(n).ToList())
                .ToList();
        }
    }
}
