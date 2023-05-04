using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
  public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }
        public List<Car> Cars { get; set; }
        public int Capacity { get { return capacity; } set { capacity = value;} }

        public int Count { get { return cars.Count; } }

        public string AddCar(Car currentCar)
        {
            foreach (Car car in cars)
            {
                if (currentCar.RegistrationNumber == car.RegistrationNumber)
                {
                    return"Car with that registration number, already exists!";
                }
            }
            if (cars.Count == capacity)
            {
                return"Parking is full!";
            }
            cars.Add(currentCar);
            return $"Successfully added new car {currentCar.Make} {currentCar.RegistrationNumber}";
        }
        public string RemoveCar(string RegistrationNumber)
        {
            bool isAvailable = false;
            foreach (Car car in cars)
            {
                if (car.RegistrationNumber == RegistrationNumber)
                {
                    isAvailable = true;
                }
            }
            if (isAvailable)
            {
                Car carToRemove = cars.First(car => car.RegistrationNumber == RegistrationNumber);
                cars.Remove(carToRemove);
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }

        }
        public Car GetCar(string RegistrationNumber)
        {
            return Cars.First(car => car.RegistrationNumber == RegistrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumber)
        {
            foreach (var registrationNumber in RegistrationNumber)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}
