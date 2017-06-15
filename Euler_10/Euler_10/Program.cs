using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_10
{
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    //Find the sum of all the primes below two million. => 142913828922

    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i < 2000000; i++)
            {
                if (NumIsPrime2(i))
                {
                    primes.Add(i);
                }
            }
            long total = 0;
            foreach (int j in primes)
            {
                total = total + j;
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }

        public static bool NumIsPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; // Even number     

            for (int i = 3; i < number; i+=2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public static bool NumIsPrime2(int number)
        {
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
