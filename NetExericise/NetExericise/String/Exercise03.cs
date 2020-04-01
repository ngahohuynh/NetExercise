using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise03
    {
        public string ReverseString(string s)
        {
            var charArr = s.ToCharArray();
            System.Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
