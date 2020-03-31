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
            var result = new List<List<int>>();
            for (var i = 0; i < (float)arr.Length / n; i++)
            {
                result.Add(arr.Skip(i * n).Take(n).ToList());
            }

            return result;
        }
    }
}
