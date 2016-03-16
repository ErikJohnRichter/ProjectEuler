using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    class Program
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.

        static void Main(string[] args)
        {
            List<int> palindromicNumbers = new List<int>();
            int b = 100;
            while (b < 1000)
            {
                int a = 100;
                while (a < 1000)
                {
                    int c = a*b;
                    string number = c.ToString();
                    string forward = "";
                    string backward = "";
                    foreach (char i in number)
                    {
                        forward = forward + i;
                        backward = i + backward;
                    }
                    if (forward == backward)
                    {
                        int palindrome = Convert.ToInt32(forward);
                        palindromicNumbers.Add(palindrome);
                    }
                    a++;
                }
                b++;
            }
            palindromicNumbers.Sort();
            Console.WriteLine(palindromicNumbers[palindromicNumbers.Count-1]);
            Console.ReadKey();
        }
    }
}
