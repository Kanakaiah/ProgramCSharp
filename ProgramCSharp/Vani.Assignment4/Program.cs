using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vani.Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Year = 2016;
            myCar.Color = "Black";
            myCar.Size = "Big";
            myCar.Company = "Toyota";
            Console.WriteLine("\"{0}\" {1}\" {2}\" {3}\"", myCar.Year, myCar.Color, myCar.Size, myCar.Company);
            decimal carPrice = GetPrice(myCar);
            Console.WriteLine("{0:c}", carPrice);
            Console.ReadLine();
        }
        public static decimal GetPrice(Car car)
        {
            decimal price;
            if (car.Size == "Big")
            {
                price = 3000;
            }

            else
            {
                price = 2000;
            }
            return price;
        }

    }

    class Car
    {

        public int Year { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Company { get; set; }
    }
}
