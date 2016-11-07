using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumOfPalindromes;
            string stringOfPalindromes = null;
            int count = 0;
            string[] arrayOfStrings = new string[7];
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                arrayOfStrings[i] = Console.ReadLine();
            }
            foreach(string word in arrayOfStrings)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            for(int i = 0; i < arrayOfStrings.Length; i++)
            {
                char[] stringCharArray = arrayOfStrings[i].ToCharArray();
                if (stringCharArray ==stringCharArray.Reverse())
                {
                    stringOfPalindromes = stringCharArray + "," + stringOfPalindromes;
                    count = count + 1;
                    
                    stringCharArray= null;

                }
                else
                {
                    i++;
                }

                

            }
            totalNumOfPalindromes = count;


            Console.WriteLine("The number of Palindrome strings are {0}", totalNumOfPalindromes);
            Console.WriteLine(stringOfPalindromes);
            Console.ReadLine();
        }
    }
}
