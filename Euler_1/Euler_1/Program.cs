using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int total = 0;
            numbers.AddRange(Enumerable.Range(1,999));
            foreach (int i in numbers)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total = total+i;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }
    }
}
