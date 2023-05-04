using System;

namespace CarSalesman;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Engine> engineList = new List<Engine>();
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            Engine engine = CreateEngine(input);
            engineList.Add(engine);
        }

        int m = int.Parse(Console.ReadLine());
        for (int j = 0; j < m; j++)
        {
            string[] input2 = Console.ReadLine().Split(" ");
            Car car = CreateCar(input2,engineList);
            cars.Add(car);
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

     static Car CreateCar(string[] input2, List<Engine> engineList)
    {
        Engine engine = engineList.Find(x => x.ModelEngine == input2[1]);
        Car car = new(input2[0], engine);
        if (input2.Length > 2)
        {
            int weight;
            bool isDigit = int.TryParse(input2[2], out weight);

            if (isDigit)
            {
                car.Weight = weight;
            }
            else
            {
                car.Colour = input2[2];
            }

            if (input2.Length > 3)
            {
                car.Colour = input2[3];
            }
        }
        return car;
    }

    static Engine CreateEngine(string[] input)
    {
        Engine engine = new(
            input[0],
            int.Parse(input[1]));

        if (input.Length > 2)
        {
            int displacement;
             bool isDigit = int.TryParse(input[2], out displacement);

            if (isDigit)
            {
                engine.Displacement = displacement;
            }
            else
            {
                engine.Efficiency = input[2];
            }
        }
        if (input.Length > 3)
        {
            engine.Efficiency = input[3];
        }
        return engine;
    }
}