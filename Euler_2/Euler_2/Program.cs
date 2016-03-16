using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4000000;
            int a = 1;
            int b = 1;
            int sum = 0;
            while (b < limit)
            {
                if (b%2 == 0)
                {
                    sum = sum + b;
                }
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
