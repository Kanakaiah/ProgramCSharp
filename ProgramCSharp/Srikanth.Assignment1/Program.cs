using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srikanth.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sum of  {0}+{1} is {2}", 1, 2, (1 + 2));
            Console.WriteLine("Difference of {0}-{1}, is {2}", 1, 2, (1 - 2));
            Console.WriteLine("Product of {0}*{1} is {2}", 2, 2, (2 * 2));

            Console.WriteLine("9th Table");


            int i = 1;

            for (i = 1; i <= 90; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
