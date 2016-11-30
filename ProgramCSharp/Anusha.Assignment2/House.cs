using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anusha.Assignment2
{
    public class House
    {
        public string typeOfHouse { get; set; }
        public float costOfHouse { get; set; }
        public int numberOfRooms { get; set; }
        public int yearBuilt { get; set; }
        public string ownerofHouse { get; set; }

        public  House GetPriceOfHouse()
        {
            House house = new House();
            Console.WriteLine("Enter your name");
            ownerofHouse = Console.ReadLine();
            Console.WriteLine("Enter type of house");
            typeOfHouse = Console.ReadLine();
            Console.WriteLine("Enter number of rooms");
            numberOfRooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year built");
           yearBuilt =int.Parse( Console.ReadLine());
           if(typeOfHouse == "Apartment")
            {
                if (numberOfRooms == 1)
                {
                    costOfHouse = 200000;
                }
                else
                {
                    costOfHouse = 280000;
                }
            }
           else if(typeOfHouse == "Condo")
            {
                costOfHouse = 300000;
            }
           else if(typeOfHouse == "Townhome")
            {
                costOfHouse = 400000;
            }
           else if(typeOfHouse == "Individual")
            {
                costOfHouse = 570000;
            }
           else
            {
                Console.WriteLine("Not applicable");
            }
            return house;
                }
        

    }
}
