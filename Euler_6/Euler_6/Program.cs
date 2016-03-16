using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_6
{
    class Program
    {
        //The sum of the squares of the first ten natural numbers is,
        //    1^2 + 2^2 + ... + 10^2 = 385
        //The square of the sum of the first ten natural numbers is,
        //    (1 + 2 + ... + 10)^2 = 55^2 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(Enumerable.Range(1,100));
            int sum1 = 0;
            int sum2 = 0;
            foreach (int i in numbers)
            {
                sum1 = sum1 + (i*i);
                sum2 = sum2 + i;
            }
            Console.WriteLine((sum2 * sum2) - sum1);
            Console.ReadKey();
        }
    }
}
