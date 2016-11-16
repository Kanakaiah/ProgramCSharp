using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhika.Assignment3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Select the one ofthe Option Below  ");
                Console.WriteLine("1. Multiplication            2. Cumulative");
                Console.WriteLine("3. Reverse                   4. Exit");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Multiplication();
                }
                if (option == 2)
                {
                    Cumulative();
                }
                if (option == 3)
                {
                    ReverseNumber();
                }
                if (option == 4)
                {
                    return;
                }
            }
            while (option != 4);
        }
        static void Multiplication()
        {
            Console.WriteLine("Enter the number :");
            int j = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i <= 10; i++)
            {

                Console.WriteLine("{0}*{1} = {2}", i, j, i * j);

            }
            Console.ReadLine();
        }
        static void ReverseNumber()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (number > 0)
            {
                int j;
                j = number % 10;
                reverse = reverse * 10 + j;

                number = number / 10;
            }
            Console.WriteLine(reverse);
        }
        static void Cumulative()
        {
            Console.WriteLine("Enter The String :");
            string s = Console.ReadLine();


            string temp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {

                temp = temp + s[i];
                Console.WriteLine(temp);
            }
        }
   }
}
