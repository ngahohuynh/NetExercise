using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExericise.Basic
{
    public class Exercise03
    {
        public string PrimeFactors(int n)
        {
            if (IsPrime(n)) return n.ToString();

            StringBuilder sb = new StringBuilder();
            int i = 2;
            while(n > 1)
            {
                if (n % i == 0 && IsPrime(i))
                {
                    sb.Append(i + " * ");
                    n /= i;
                }
                else i++;
            }
            sb.Remove(sb.Length - 3, 3);

            return sb.ToString();
        }

        bool IsPrime(int n)
        {
            if (n == 0) return false;
            if (n == 1 || n == 2) return true;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
