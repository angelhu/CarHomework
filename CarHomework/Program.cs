using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHomework
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineSize { get; set; }
        public int Horsepower { get; set; }

        public string CarMakeModel()
        {
            return $"{Make} {Model}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.Make = "BMW";
            car1.Model = "320i";
            car1.EngineSize = 4;
            car1.Horsepower = 180;

            car2.Make = "Mercedes-Benz";
            car2.Model = "C 300";
            car2.EngineSize = 4;
            car2.Horsepower = 241;

            car3.Make = "Audi";
            car3.Model = "A4";
            car3.EngineSize = 4;
            car3.Horsepower = 190;

            Console.WriteLine($"{car1.CarMakeModel()} is a car with a {car1.EngineSize}-cylinder engine and has {car1.Horsepower} horsepower.");
            Console.WriteLine($"{car2.CarMakeModel()} is a car with a {car2.EngineSize}-cylinder engine and has {car2.Horsepower} horsepower.");
            Console.WriteLine($"{car3.CarMakeModel()} is a car with a {car3.EngineSize}-cylinder engine and has {car3.Horsepower} horsepower.");
        }
    }
}
