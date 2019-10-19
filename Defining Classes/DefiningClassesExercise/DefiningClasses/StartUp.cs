using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOFCars = int.Parse(Console.ReadLine());
            Car carList = new Car();

            for (int i = 0; i < numberOFCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelPerKm = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelPerKm);
                carList.AddCar(car);
            }

            string[] commands = Console.ReadLine()
                .Split()
                .ToArray();

            while (commands[0] != "End")
            {
                string model = commands[1];
                double km = double.Parse(commands[2]);

                Car currentCar = carList.GetCar(model);

                if (!carList.CanTravel(currentCar, km))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                commands = Console.ReadLine()
                .Split()
                .ToArray();
            }

            var finalList = carList.GetCarList();

            foreach (var car in finalList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledKm}");
            }
        }
    }
}
