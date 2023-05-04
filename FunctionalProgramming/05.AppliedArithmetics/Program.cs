

using System.Linq;

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

//делегирам променлива на функция, която връща воид и печата на конзолата
Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));

// делегирам променлива на функция, която връща като резултат списък с числа, модифицирани вследствие, получени команди от конзолата. Като параметри приема стринг за командата, инт за числата и връща като резултат списък с модифицираните числа.
Func<string, List<int>, List<int>> moderateNumbers = (comand, numbers) =>
{
    List<int> result = new List<int>();
    foreach (var number in numbers)
    {
        switch (comand)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
        }
    }
    return result;
};

// 
string comand = String.Empty;
while ((comand = Console.ReadLine()) != "end")
{
    if (comand == "print")
    {
        // извикваме променливата на функцията за печатане
        print(numbers);
    }
    else 
    {
        // извикваме функцията за модифициране
        numbers = moderateNumbers(comand, numbers);
    }
}