using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String P = "CIVIC";
            int l = P.Length;
            Console.WriteLine(l);
            bool result = true;

            for (int i = 0; i < l - 1; i++)
            {
                if (P[i] != P[l - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("This is palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }

            Console.ReadLine();
        }
    }
}
