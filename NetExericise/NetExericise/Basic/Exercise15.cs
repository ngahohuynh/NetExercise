using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise15
    {
        public int CounDigits(int n)
        {
            if (n < 0) return 0;
            if (n <= 1) return 1;

            var digits = 0d;
            for (var i = 2; i <= n; i++)
            {
                digits += Math.Log10(i);
            }

            return (int)Math.Floor(digits) + 1;
        }
    }
}
