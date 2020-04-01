using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise01
    {
        public string TitleCaseToSnakeCase(string s)
        {
            return string.Concat(s.Select((x, i) => (i > 0 && char.IsUpper(x) ? "_" : "") + x))
                .ToLower();
        }
    }
}
