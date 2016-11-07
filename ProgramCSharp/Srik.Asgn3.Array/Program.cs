using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srik.Asgn3.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            enter_array: Console.WriteLine("Enter what type of array you want:");
            Console.WriteLine("1. Interger Array            2. Char Array");
            //string arrayInType = Console.ReadLine();
            int arrayType = Convert.ToInt16(Console.ReadLine());

            if (arrayType != 1 && arrayType != 2) 
                {
                    Console.WriteLine("Please enter only one of the above choice:");
                    goto enter_array;
                }

          
          enter_arraysize:  Console.WriteLine("Enter Size of Array between 1 and 10: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            if (arraySize < 1 || arraySize > 10)
            {
                Console.WriteLine("Please enter array size between 1 and 10:");
                goto enter_arraysize;
            }

            if (arrayType ==1)
            {
                int[] integers = new int[arraySize];
                for (int i=0;i<arraySize;i++)
                {
                    Console.WriteLine("Please enter {0}th element in Integer Array: ", i);
                    integers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine("{0}",integers[i]);
                    
                }

                
                Console.ReadLine();
            }

            if (arrayType == 2)
            {
                String[] strings = new string[arraySize];


            }

        }
    }
}
