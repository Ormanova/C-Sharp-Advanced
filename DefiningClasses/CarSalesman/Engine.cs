using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string modelEngine, int power)
        {
            ModelEngine = modelEngine;
            Power = power;
            
        }
        public string ModelEngine { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            string result =
                $"{ModelEngine}:{Environment.NewLine}" +
                $" Power: {Power}{Environment.NewLine}" +
                $" Displacement: {displacement}{Environment.NewLine}" +
                $" Efficiency: {efficiency}";
            return result;
        }
    }
}
