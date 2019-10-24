using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int engineNumber = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < engineNumber; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = input[0];
                string power = input[1];

                if (input.Length == 4)
                {
                    string displacement = input[2];
                    string efficiency = input[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else if (input.Length == 3)
                {
                    bool isNumber = Int32.TryParse(input[2], out int result);

                    if (isNumber)
                    {
                        string displacement = input[2];
                        Engine engine = new Engine(model, power, displacement, isNumber);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = input[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
                else if (input.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
            }

            int carNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carNumber; i++)
            {
                string[] input = Console.ReadLine()
                   .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                string model = input[0];
                string engine = input[1];

                Engine currentEngine = engines.Where(x => x.Model == engine).FirstOrDefault();

                if (input.Length == 4)
                {
                    string weight = input[2];
                    string color = input[3];
                    Car car = new Car(model, currentEngine, weight, color);
                    cars.Add(car);
                }
                else if (input.Length == 3)
                {
                    bool isNumber = Int32.TryParse(input[2], out int result);

                    if (isNumber)
                    {
                        string weight = input[2];
                        Car car = new Car(model, currentEngine, weight, isNumber);
                        cars.Add(car);
                    }
                    else
                    {
                        string color = input[2];
                        Car car = new Car(model, currentEngine, color);
                        cars.Add(car);
                    }
                }
                else if (input.Length == 2)
                {
                    Car car = new Car(model, currentEngine);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
