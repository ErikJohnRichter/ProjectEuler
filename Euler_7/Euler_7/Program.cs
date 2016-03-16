using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Euler_7
{
    class Program
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10,001st prime number? 104743

        static void Main(string[] args)
        {
            bool loop = true;
            long number = 4;
            long primes = 2;
            while (loop)
            {
                if (primes == 10001)
                {
                    Console.WriteLine(number-1);
                    Console.ReadKey();
                }
                else
                {
                    if (IsPrime2(number))
                    {
                        number++;
                        primes++;
                        continue;
                    }
                    else
                    {
                        number++;
                        continue;
                    }
                }
            }
        }

        private static bool IsPrime1(long n)
        {
            if (n == 1)
            {
                return false;
            }
            else if (n < 4)
            {
                return true;
            }
            else if (n % 2 == 0)
            {
                return false;
            }
            else if (n < 9)
            {
                return true;
            }
            else if (n%3 == 0)
            {
                return false;
            }
            else
            {
                double r = Math.Floor(Math.Sqrt(n));
                int f = 5;
                while (f <= r)
                {
                    if (n%f == 0)
                    {
                        return false;
                        break;
                    }
                    if (n % (f+2) == 0)
                    {
                        return false;
                        break;
                    }
                    f = f + 6;
                    continue;
                }
                return true;
            }
        }

        private static bool IsPrime2(long n)
        {
            if (n%2 == 0)
            {
                if (n == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= n; i += 2)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }

            return n != 1;
        }
    }
}
