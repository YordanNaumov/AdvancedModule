using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            var queueOfCars = new Queue<string>();
            int totalCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END") //correct
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    if (queueOfCars.Count > 0)
                    {
                        bool noCarsLeft = false;
                        string carToPass = queueOfCars.Peek();
                        for (int i = 0; i < greenLightDuration; i++)
                        {
                            carToPass = carToPass.Substring(1);
                            if (carToPass.Length == 0)
                            {
                                queueOfCars.Dequeue();
                                totalCarsPassed++;
                                if (queueOfCars.Count > 0)
                                {
                                    carToPass = queueOfCars.Peek();
                                }
                                else
                                {
                                    noCarsLeft = true;
                                    break;
                                } 
                            }
                        }
                        if (noCarsLeft)
                        {
                            continue;
                        }
                        for (int i = 0; i < freeWindowDuration; i++)
                        {
                            carToPass = carToPass.Substring(1);
                            if (carToPass.Length == 0)
                            {
                                queueOfCars.Dequeue();
                                totalCarsPassed++;
                                break;
                            }
                        }
                        if (carToPass.Length > 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{queueOfCars.Peek()} was hit at {carToPass[0]}.");
                            break;
                        }
                    }
                }
                else //correct
                {
                    queueOfCars.Enqueue(command);
                }
            }
        }
    }
}
