using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise10
    {
        public string SplitFirstAndLastName(string s)
        {
            string[] name = s.Split(' ');
            name[name.Length - 2] += ",";
            return string.Join(" ", name);
        }
    }
}
