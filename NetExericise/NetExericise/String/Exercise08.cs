using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise08
    {
        public string RemoveDuplicates(string s)
        {
            var sb = new StringBuilder();
            var ch = '\0';

            foreach (var letter in s)
            {
                if (letter != ch)
                {
                    sb.Append(letter);
                    ch = letter;
                }
            }

            return sb.ToString();
        }
    }
}
