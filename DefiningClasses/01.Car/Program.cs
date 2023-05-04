namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                string[] tockens = input.Split(" ").ToArray();
                for (int i = 0; i < tockens.Length; i++)
                {
                    if (i % 2 == 0)
                    {

                        int currentYear = int.Parse(tockens[i]);
                        double currentPressure = double.Parse(tockens[i + 1]);
                        var currentTires = new Tire(currentYear, currentPressure);
                        Car car = new Car();
                        car.Tires = currentTires;
                    }
                }
            }
            string input2 = string.Empty;
            while (input2 != "Engines done")
            {
                string[] tockens = input2.Split(" ");
                int currentHorsePower = int.Parse(tockens[0]);
                double currentCubicCapacity = double.Parse(tockens[1]);
                var engine = new Engine (currentHorsePower, currentCubicCapacity);
                Car car = new Car();
                car.Engine = engine;
            }
            string input3 = string.Empty;
            while (input3 != "Show special")
            {
                string[] tockens = input3.Split(" ");
                 string nam
            }





        }
    }
}