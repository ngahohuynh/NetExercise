using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Array
{
    public class Exercise01
    {
        public string NumbersAppearTwice(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var num in arr)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }

                else if (dict[num] == 1)
                {
                    dict[num]++;
                }

                else if (dict[num] == 2)
                {
                    dict[num]++;
                    result.Add(num);
                }
            }

            return string.Join(" ", result);
        }
    }
}
