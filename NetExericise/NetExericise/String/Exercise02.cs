﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise02
    {
        public string SnakeCaseToTitleCase(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            var sb = new StringBuilder();
            sb.Append(char.ToUpper(s[0]));

            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == '_')
                {
                    if (i < s.Length - 1)
                    {
                        sb.Append(char.ToUpper(s[i + 1]));
                        i++;
                    }
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
