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

            foreach (var ch in s)
            {
                if (char.IsNumber(ch))
                {
                    number = number * 10 + (ch - '0');
                }

                else
                {
                    sum += number;
                    number = 0;
                }
            }

            return sum + number;
        }
    }
}
