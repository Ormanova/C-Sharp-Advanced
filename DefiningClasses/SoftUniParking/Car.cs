using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;  
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {Make}{Environment.NewLine}");
            sb.Append($"Model: {Model}{Environment.NewLine}");
            sb.Append($"HorsePower: {HorsePower}{Environment.NewLine}");
            sb.Append($"RegistrationNumber: {RegistrationNumber}");
            return sb.ToString();

        }
    }
}
