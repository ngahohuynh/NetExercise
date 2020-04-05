using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise09
    {
        public bool CheckBarcode(string s)
        {
            var sum = s.Where((ch, i) => i % 2 == 0).Sum(ch => ch - '0')
                    + s.Where((ch, i) => i % 2 != 0).Sum(ch => 3 * (ch - '0'));
            return sum % 10 == 0;
        }
    }
}
