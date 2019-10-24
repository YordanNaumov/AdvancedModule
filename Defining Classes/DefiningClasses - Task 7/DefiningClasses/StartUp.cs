using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
         public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Tire[] tires = new Tire[4];

                for (int tireNumber = 5, p = 0; tireNumber < input.Length; tireNumber += 2, p++)
                {
                    double tirePressure = double.Parse(input[tireNumber]);
                    int tireAge = int.Parse(input[tireNumber + 1]);

                    Tire tire = new Tire(tirePressure, tireAge);

                    tires[p] = tire;
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(car => car.Cargo.CargoType == "fragile" && car.Tires.Any(p => p.TirePressure < 1))
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
            else if (command == "flamable")
            {
                cars
                    .Where(car => car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
