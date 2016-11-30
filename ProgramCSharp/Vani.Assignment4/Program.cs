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
            decimal carPrice = GetCarPrice(myCar);
            Console.WriteLine("{0:c}", carPrice);
            Console.ReadLine();
            House myHouse = new House();
            myHouse.Year = 2016;
            myHouse.Location = "Bothell";
            myHouse.Builder = "TollBrothers";
            myHouse.Model = "Kingston";
            Console.WriteLine("\"{0}\"{1}\" {2}\" {3}\"", myHouse.Year, myHouse.Location, myHouse.Builder, myHouse.Model);
            decimal housePrice = GetHousePrice(myHouse);
            Console.WriteLine("{0:c}", GetHousePrice(myHouse));
            Console.ReadLine();

        }
        public static decimal GetCarPrice(Car car)
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
        public static decimal GetHousePrice(House house)
        {
            decimal hprice;
            if (house.Model == "Kingston")
            {
                hprice = 700000;
            }
            else
            {
                hprice = 500000;
            }
            return hprice;
        }

    }

    class Car
    {

        public int Year { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Company { get; set; }
    }
    class House
    {
        public int Year { get; set; }
        public string Location { get; set; }
        public string Builder { get; set; }
        public string Model { get; set; }
    }
}
