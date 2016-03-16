using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_3
{
    class Program
    {

        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?
        public static void Main(string[] args)
        {
            long n = 600851475143;
            List<int> range = new List<int>();
            List<int> primeFactors = new List<int>();
            range.AddRange(Enumerable.Range(1, 1000000));
            foreach (int i in range)
            {
                if (n%i == 0)
                {
                    primeFactors.Add(i);
                }
            }
            primeFactors.Remove(primeFactors[0]);
            long factor = 1;
            int k = 0;
            foreach (int j in primeFactors)
            {
                if (factor < n)
                {
                    factor = factor*j;
                    k++;
                }
                else
                {
                    Console.WriteLine(primeFactors[k-1]);
                    Console.ReadKey();
                    break;
                }
            }
            

            //long n = 600851475143;
            //for (int i = 1; i <= Math.Sqrt(n) + 1; i++)
            //    if (n % i == 0 && IsPrime(i))
            //        Console.Write(" " + i);
            //Console.ReadKey();
        }

        //public static bool IsPrime(int number)
        //{
        //    if (number == 1 || number == 2)
        //        return true;

        //    for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
        //        if (number % i == 0)
        //            return false;


        //    return true;
        //}
    }
}
