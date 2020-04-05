using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.String
{
    public class Exercise05
    {
        public bool IsPalindrome(string s)
        {
            var charArr = s.ToCharArray();
            System.Array.Reverse(charArr);
            return string.Equals(s, new string(charArr));
        }
    }
}
