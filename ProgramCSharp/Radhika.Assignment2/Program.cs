using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhika.Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String :");
            string s = Console.ReadLine();
            int count = 0;
            string[] substrings = s.Split(' ');
            foreach( string str in substrings)
            {
                string temp = string.Empty;
                for (int i = str.Length - 1; i >= 0; i--)
                {

                    temp = temp + str[i];
                }
                if (str== temp)
                {
                    Console.WriteLine("{0} is Palidrome ", str);
                    count++;
                }
             }
            Console.WriteLine("{0} Palidrome(s) in the String", count);
            Console.ReadLine();
         }
    }
}
