using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise07
    {
        public string ConvertString(string s)
        {
            var sb = new StringBuilder();
            var len = 0;
            var ch = '\0';

            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    len = len * 10 + (s[i] - '0');
                    if (i == s.Length - 1 || !char.IsNumber(s[i + 1]))
                    {
                        for (var j = 1; j < len; j++)
                        {
                            sb.Append(ch);
                        }
                    }
                }

                else
                {
                    ch = s[i];
                    sb.Append(ch);
                    len = 0;
                }
            }

            return sb.ToString();
        }
    }
}
