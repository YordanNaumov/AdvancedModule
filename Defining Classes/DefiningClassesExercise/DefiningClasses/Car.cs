using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelPerKm;
        private double travelledKm;
        private List<Car> carList;

        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKm = fuelPerKm;
            this.TravelledKm = 0;
        }

        public Car()
        {
            this.carList = new List<Car>();
        }

        public void AddCar(Car car)
        {
            this.carList.Add(car);
        }

        public Car GetCar(string model)
        {
            foreach (var car in carList)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }

            return null;
        }


        public bool CanTravel(Car car, double km)
        {
            bool isValid = (car.FuelPerKm * km) <= car.FuelAmount;

            if (isValid)
            {
                car.FuelAmount -= car.FuelPerKm * km;
                car.TravelledKm += km;

                return true;
            }

            return false;
        }

        public List<Car> GetCarList()
        {
            return this.carList;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKm { get; set; }
        public double TravelledKm { get; set; }
    }
}
