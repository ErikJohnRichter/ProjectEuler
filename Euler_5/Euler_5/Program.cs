using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Euler_5
{
    class Program
    {

        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
        static void Main(string[] args)
        {
            int max = 20;
            bool still = true;
            long x = 1;
            while (still)
            {
                int count = 1;
                while (count < max+1)
                {
                    if (x%count == 0)
                    {
                        if (count == max)
                        {
                            Console.WriteLine(x);
                            Console.ReadKey();
                        }
                        count++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                x++;
            }
        }
    }
}
