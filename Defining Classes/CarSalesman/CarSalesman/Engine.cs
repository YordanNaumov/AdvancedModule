using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        //•	Model
        //•	Power
        //•	Displacement
        //•	Efficiency

        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public Engine(string model, string power, string displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public Engine(string model, string power, string displacement, bool isNumber)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = "n/a";
        }
        public Engine(string model, string power, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = efficiency;
        }
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
    }
}
