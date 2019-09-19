using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            var petrolGiven = new List<int>();
            var distanceToTravel = new List<int>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] information = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                petrolGiven.Add(information[0]);
                distanceToTravel.Add(information[1]);
            }

            bool pumpFound = false;
            for (int currentPump = 0; currentPump < numberOfPumps; currentPump++)
            {
                var testPetrol = new Queue<int>(petrolGiven);
                var testDistance = new Queue<int>(distanceToTravel);
                int petrolTank = 0;
                for (int i = currentPump; i < numberOfPumps + currentPump; i++)
                {
                    petrolTank += testPetrol.Peek();
                    if (petrolTank >= testDistance.Peek())
                    {
                        petrolTank -= testDistance.Peek();
                        testPetrol.Dequeue();
                        testDistance.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                    if (i == numberOfPumps + currentPump - 1)
                    {
                        pumpFound = true;
                        Console.WriteLine(currentPump);
                        break;
                    }
                }
                if (pumpFound)
                {
                    break;
                }
                SwitchPump(petrolGiven);
                SwitchPump(distanceToTravel);
            }
        }

        static List<int> SwitchPump(List<int> list)
        {
            list.Add(list[list.Count - 1]);
            list.RemoveAt(0);
            list.TrimExcess();
            return list;
        }
    }
}
