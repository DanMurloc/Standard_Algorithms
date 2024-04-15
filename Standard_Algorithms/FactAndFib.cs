using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Algorithms
{
    public class FactAndFib
    {

        public int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;

            return n * Factorial(n - 1);
        }

        public int FactorialFor(int n)
        {
            if (n == 1 || n == 0) return 1;
            int Fsum = 1;
            for (int i = n; i > 0; i--)
            {
                Fsum *= i;
            }
            return Fsum;
        }

        public int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        public int FibonachiFor(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }

        public int Multi(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

        public int MultReq(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            return a+MultReq(a,b-1);
        }
    }
}
