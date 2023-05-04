
using System;
namespace SpeedRacing;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string,Car> cars = new Dictionary<string,Car>();

        for (int i = 1; i <= n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");

            Car car = new()
            {
                Model = input[0],
                FuelAmount = double.Parse(input[1]),
                FuelConsumptionPerKilometer = double.Parse(input[2])
            };
            cars.Add(car.Model, car);
                
        }
        string input2 = string.Empty;
        while ((input2 = Console.ReadLine()) != "End")
        {
            string[] input2Props = input2.Split(" ");

            string model = input2Props[1];
            double amountKilometers = double.Parse(input2Props[2]);
            Car car = cars[model];
            car.Drive(amountKilometers);
           
        }
        foreach (var car in cars.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
        }
    }
}

