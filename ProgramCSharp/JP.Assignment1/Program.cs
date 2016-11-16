using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howmany number of strings would you like to provide?");
            int totalWords = Convert.ToInt16((Console.ReadLine()));
            string[] words = new string[totalWords];
            string[] reverseWords = new string[totalWords];
            int count = 0;
            for (int index = 0; index < totalWords; index++)
            {
                Console.WriteLine("Please provide your string # {0}", index);
                words[index] = Console.ReadLine();
                Console.WriteLine("Your string # {0} is {1} ", index, words[index]);
                // Convert string into lower case
                words[index] = words[index].ToLower();
                words[index] = words[index].Replace(" ", "");
                char[] wordsCharArray = words[index].ToCharArray();
                Array.Reverse(wordsCharArray);
                reverseWords[index] = new string(wordsCharArray);
                Console.WriteLine("Your reversed string is: {0}", reverseWords[index]);
                if (words[index] == reverseWords[index])
                {
                    count++;
                    Console.WriteLine("{0} is polindrome", words[index]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("#################################################");
            Console.WriteLine("Number of Palindromes in list of strings is: {0}", count);
            Console.WriteLine("#################################################");
            Console.ReadLine();
        }
    }
}
