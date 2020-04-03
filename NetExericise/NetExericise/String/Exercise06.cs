using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise06
    {
        public string ConvertString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            var sb = new StringBuilder();
            var letter = '\0';
            var len = 0;

            foreach(var ch in s)
            {
                if (ch == letter)
                {
                    len++;
                }

                else
                {
                    if (len > 1) sb.Append(len);
                    len = 1;
                    letter = ch;
                    sb.Append(letter);
                }
            }

            if (len > 1) sb.Append(len);

            return sb.ToString();

        }
    }
}
