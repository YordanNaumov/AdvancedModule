using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        //          •	Model
        //          •	Engine
        //          •	Weight 
        //          •	Color

        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public Car(string model, Engine engine, string weight, bool isNumber)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = color;
        }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
