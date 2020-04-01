using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise04
    {
        public int SumOfNumbers(string s)
        {
            var sum = 0;
            var number = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    number = number * 10 + (s[i] - '0');
                }

                if (i == s.Length - 1 || !char.IsNumber(s[i + 1]))
                {
                    sum += number;
                    number = 0;
                }
            }

            return sum;
        }
    }
}
