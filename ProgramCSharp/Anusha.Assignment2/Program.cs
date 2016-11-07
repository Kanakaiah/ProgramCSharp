using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anusha.Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = new string[5];

            int totalNumOfPalindromes = 0;
            string stringOfPalindromes = null;
            int count = 0;

            //string palindromeString = null;
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("Please enter {0}th element of arrayOfStrings", i);
                arrayOfStrings[i] = Console.ReadLine();
            }
            foreach (string word in arrayOfStrings)
            {
                Console.WriteLine(word);
            }

            for (int j = 0; j < arrayOfStrings.Length; j++)
            {
                var modifiedString = arrayOfStrings[j];
                modifiedString = modifiedString.Replace(" ", "");
                arrayOfStrings[j] = modifiedString;

                char[] stringCharArray = arrayOfStrings[j].ToCharArray();
                for (int k = 0; k < stringCharArray.Length; k++)
                {
                    count = 0;

                    if (stringCharArray[k] == stringCharArray[(((stringCharArray.Length) - 1) - k)])
                    {

                        count = count + 1;
                       
                    }
                    else
                    {
                        count = 0;
                        break;

                    }

                }
                if (count > 0)
                {
                    totalNumOfPalindromes = totalNumOfPalindromes + 1;
                    stringOfPalindromes = arrayOfStrings[j] + "," + stringOfPalindromes;
                }

            }


            Console.WriteLine("The number of Palindrome strings are {0}", totalNumOfPalindromes);
            Console.WriteLine(stringOfPalindromes);
            Console.ReadLine();

            
            
        }
    }
}

        
    

