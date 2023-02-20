using System;
using CarManufacturer;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            Console.WriteLine(car.Make);
        }
    }
}
