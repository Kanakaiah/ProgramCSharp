using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vani.Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (isExit == false)
            {
                isExit = DisplayMenu();
            }
        }
        private static bool DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Printing Table num");
            Console.WriteLine("2. Reverse Number");
            Console.WriteLine("3. printing Name");
            Console.WriteLine("4. Exit ");
            Console.Write("Enter your Choice:");
            String UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                printTablenum();
                return false;
            }
            else if (UserInput == "2")
            {
                reverseNum();
                return false;
            }
            else if (UserInput == "3")
            {
                printingName();
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void printTablenum()
        {
            Console.WriteLine("Printing Table num");

            int num;
            Console.WriteLine("Write the table num");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} ={2}", num, i, i * num);
            }
            Console.ReadLine();
        }
        private static void reverseNum()
        {
            Console.WriteLine("reverseNum");
            int num;
            int reverse = 0;

            Console.WriteLine("Enter a number");

            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is :" + reverse);
            Console.ReadLine();
        }
        private static void printingName()
        {

            Console.WriteLine("printing name");

            Console.WriteLine(" Enter the name :");
            string myName = Console.ReadLine();
            string myTemp = " ";
            for (int index = 0; index < myName.Length; index++)
            {
                myTemp = myTemp + myName[index];
                Console.WriteLine(myTemp);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
        }
}
