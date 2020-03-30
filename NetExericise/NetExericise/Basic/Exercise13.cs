using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise13
    {
        public string GenerateIpAddresses(string s)
        {
            List<string> result = new List<string>();

            StringBuilder ip = new StringBuilder();

            Traverse(result, ip, 0, 0, s);
            return string.Join(", ", result);
        }

        void Traverse(List<string> result, StringBuilder ip, int segment, int start, String s)
        {
            if (segment == 4)
            {
                if (start == s.Length)
                {
                    ip.Length--;
                    result.Add(ip.ToString());
                }
                return;
            }

            var len = 0;
            var num = 0;

            for (int i = start; i < Math.Min(s.Length, start + 3); i++)
            {
                if (i > start && num == 0)
                    return;

                num = num * 10 + (s[i] - '0');

                if (num > 255)
                    return;

                len = ip.Length;
                ip.Append(num).Append(".");
                Traverse(result, ip, segment + 1, i + 1, s);
                ip.Length = len;
            }
        }
    }
}
