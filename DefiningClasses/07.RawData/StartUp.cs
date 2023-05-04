using System;

namespace RawData;

public class StartUp
{
    static void Main(string[] args)
    {
        int numberCars = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

        for (int i = 0; i < numberCars; i++)
        {
            string[] input = Console.ReadLine().Split(" ");

            Car car = new(
                input[0],
                int.Parse(input[1]),
                int.Parse(input[2]),
                int.Parse(input[3]),
                input[4],
                double.Parse(input[5]),
                int.Parse(input[6]),
                double.Parse(input[7]),
                int.Parse(input[8]),
                double.Parse(input[9]),
                int.Parse(input[10]),
                double.Parse(input[11]),
                int.Parse(input[12])
            );
            cars.Add(car);
        }
        string comand = Console.ReadLine();
        string[] filterCars;
        if (comand == "fragile")
        {
            //print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1
            filterCars = cars
                .Where((c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1)))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            //print all cars, whose cargo is "flammable" and have engine power > 250
            filterCars = cars
               .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
               .Select(c => c.Model)
               .ToArray();
        }
        Console.WriteLine(String.Join(Environment.NewLine, filterCars));
    }
}
