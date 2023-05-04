using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        private string model;
        private int speed;
        private int power;
        private int weight;
        private string type;
        private double tyre1Pressure;
        private int tyre1Age;
        private double tyre2Pressure;
        private int tyre2Age;
        private double tyre3Pressure;
        private int tyre3Age;
        private double tyre4Pressure;
        private int tyre4Age;

        public Car(string model, int speed, int power, int weight, string type, double tyre1Pressure, int tyre1Age, double tyre2Pressure, int tyre2Age, double tyre3Pressure, int tyre3Age, double tyre4Pressure, int tyre4Age)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new(weight, type);
            Tyres = new Tyre[4];
            Tyres[0] = new(tyre1Age, tyre1Pressure);
            Tyres[1] = new(tyre2Age, tyre2Pressure);

            Tyres[2] = new(tyre3Age, tyre3Pressure);

            Tyres[3] = new(tyre4Age, tyre4Pressure);


        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo  { get; set; }

        public Tyre[]  Tyres { get; set; }

    }
}
