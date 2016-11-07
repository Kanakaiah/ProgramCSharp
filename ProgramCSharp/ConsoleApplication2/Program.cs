using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Enter the String here");
            string s = Console.ReadLine();
            string [] substring = s.Split();                     // Storing the individual string values in to the array
            int x = 0;
            foreach (string str in substring)
            {
                string strtemp = string.Empty;                   //Declaring the empty String for storing the reverse string
                for (int j = str.Length - 1; j >= 0; j--)        // Reverse each substring
                {
                    strtemp = strtemp + str[j];                  // Writing the reverse string valuen in to the temp varible strtemp
                }
                if (strtemp == str)
                {
                    x++;                                         // Conting the no.of Palindromes
                    Console.WriteLine("{0} Palidrome", str);
                }
            }
            Console.WriteLine("There are {0} Palindromes in the String", x);
            Console.ReadLine();
        }
    }
}
