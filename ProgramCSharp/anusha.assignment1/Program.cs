using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anusha.assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num1 = 7;
            // int num2 = 89;
            // int sum = num1 + num2;
            // int product = num1 * num2;
            // int diff = num2 - num1;
            // string name = "Anusha";
            //string DOB =" 11 /09 / 84";
            // string address = "33926 SE strouf st Snoqualmie"; 
            // Console.WriteLine("The sum  of {0} and {1} is {2} and prodict is {3} and difference is {4}",num1,num2,sum,product,diff);

            // Console.WriteLine("Hello world");
            // Console.WriteLine("My name is" + " " + name + " " + "and my DOB is" + "  " + DOB + " " + "and i live at" + " " +"'"+ address+"'.");
            // Console.ReadLine();
            //int num1;
            //int num2;
            //Console.WriteLine("Enter First number:");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second number:");
            //num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //int product = num1 * num2;
            //int diff = num2 - num1;
            //Console.WriteLine("The sum  of {0} and {1} is {2} and product is {3} and difference is {4}", num1, num2, sum, product, diff);
            //Console.ReadLine();
            /*----------------------------*/
            /* BIBLE QUIZ ASSIGNMENT*/

            //Console.WriteLine("Welcome to Bible Quiz..");
            //Console.WriteLine();
            //float score;
            //int count = 0;

            //Console.WriteLine("Please select one option for each Question");

            //Console.WriteLine();
            //Console.WriteLine("Q1.How many books are there in Bible?");
            //Console.WriteLine("1.24        2.66");
            //Console.WriteLine("3.45        4.67");
            //Console.WriteLine();
            //byte userAnswer1 = Convert.ToByte(Console.ReadLine());
            //if (userAnswer1 == 2)
            //{
            //    Console.WriteLine("You gave right answer");
            //    count = count + 1;
            //}
            //else if (userAnswer1 == 1 || userAnswer1 == 3 || userAnswer1 == 4)
            //{
            //    Console.WriteLine(":):)Wrong answer");

            //}
            //else
            //{
            //    Console.WriteLine("Select only from given options,you've got it wrong");

            //}

            //Console.WriteLine();
            //Console.WriteLine("Q1.How many divisions are there in Bible?");
            //Console.WriteLine("1.1        2.2");
            //Console.WriteLine("3.4        4.7");
            //Console.WriteLine();
            //byte userAnswer2 = Convert.ToByte(Console.ReadLine());
            //if (userAnswer2 == 2)
            //{
            //    Console.WriteLine("You gave right answer");
            //    count = count + 1;
            //}
            //else if (userAnswer2 == 1 || userAnswer2 == 3 || userAnswer2 == 4)
            //{
            //    Console.WriteLine(":):)Wrong answer");

            //}
            //else
            //{
            //    Console.WriteLine("Select only from given options,you've got it wrong");

            //}
            //Console.WriteLine("Q1.How many books are there in Old Testament?");
            //Console.WriteLine("1.24        2.66");
            //Console.WriteLine("3.39        4.67");
            //Console.WriteLine();
            //byte userAnswer3 = Convert.ToByte(Console.ReadLine());
            //if (userAnswer3 == 3)
            //{
            //    Console.WriteLine("You gave right answer");
            //    count = count + 1;
            //}
            //else if (userAnswer3 == 1 || userAnswer3 == 2 || userAnswer3 == 4)
            //{
            //    Console.WriteLine(":):)Wrong answer");

            //}
            //else
            //{
            //    Console.WriteLine("Select only from given options,you've got it wrong");
            //}
            //Console.WriteLine("Q1.How many books are there in New Testament?");
            //Console.WriteLine("1.24        2.66");
            //Console.WriteLine("3.45        4.27");
            //Console.WriteLine();
            //byte userAnswer4 = Convert.ToByte(Console.ReadLine());
            //string message;
            //message = (userAnswer4 == 4) ? "You gave right answer" : ":):)Wrong answer,Choose correct option";
            ////if (userAnswer4 == 4)
            ////{
            ////    Console.WriteLine("You gave right answer");
            ////    count = count + 1;
            ////}
            ////else if (userAnswer4 == 1 || userAnswer4 == 3 || userAnswer4 ==2)

            ////    Console.WriteLine(":):)Wrong answer");


            ////else

            //   Console.WriteLine(message);

            //Console.WriteLine();
            //score = count * 20;
            //float maxScore = 80;
            //float percentage = ((score / maxScore) * 100);
            //Console.WriteLine("your Score is {0} and you got {1} %", score, percentage);
            //if (percentage > 70 && percentage <= 100)

            //    Console.WriteLine("Grade A");

            //else if (percentage >= 50 && percentage <= 70)

            //    Console.WriteLine("Grade B");

            //else

            //    Console.WriteLine("Fail");

            //Console.ReadLine();


            //            string[] arrayOfStrings = new string[5];

            //            int totalNumOfPalindromes = 0;
            //            string stringOfPalindromes = null;
            //            int count = 0;

            //            string palindromeString = null;
            //            for (int i = 0; i < arrayOfStrings.Length; i++)
            //            {
            //                Console.WriteLine("Please enter {0}th element of arrayOfStrings", i);
            //                arrayOfStrings[i] = Console.ReadLine();
            //            }
            //            foreach (string word in arrayOfStrings)
            //            {
            //                Console.WriteLine(word);
            //            }

            //            for (int j = 0; j < arrayOfStrings.Length; j++)
            //            {

            //                char[] stringCharArray = arrayOfStrings[j].ToCharArray();
            //                for (int k = 0; k < stringCharArray.Length; k++)
            //                {
            //                    count = 0;

            //                    if (stringCharArray[k] == stringCharArray[(((stringCharArray.Length) - 1) - k)])
            //                    {

            //                        //palindromeString = palindromeString + arrayOfStrings[j];

            //                        count = count + 1;
            //                        //char palindromeCharacters = ' ';
            //                        //palindromeCharacters = palindromeCharacters + stringCharArray[k];
            //                        //palindromeString =  palindromeString + (palindromeCharacters.ToString) ; 
            //                    }
            //                    else
            //                    {
            //                        count = 0;
            //                        break;

            //                    }

            //                }
            //                if(count > 0)
            //                {
            //                    totalNumOfPalindromes = totalNumOfPalindromes + 1;
            //                    stringOfPalindromes = arrayOfStrings[j] + "," + stringOfPalindromes;
            //                }

            //            }


            //            Console.WriteLine("The number of Palindrome strings are {0}", totalNumOfPalindromes);
            //            Console.WriteLine(stringOfPalindromes);
            //            Console.ReadLine();
        }
    }
}
