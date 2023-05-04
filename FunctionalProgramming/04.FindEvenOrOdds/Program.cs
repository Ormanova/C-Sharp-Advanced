

using System.Linq;

int[] bounderies = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
bool isEven = Console.ReadLine() == "even";

// декларирам функция, която приема инт старт, инт енд и връща списък с числа в дадените граници.
Func<int, int, List<int>> fillNumbers = (start, end) =>
{
    List<int> list = new List<int>();
    for (int i = start; i <= end; i++)
    {
        list.Add(i);
    }
    return list;
};


// извиквам функцията за да си създам листа с числа.
List<int> numbers = fillNumbers(bounderies[0], bounderies[1]);


// декларирам предикат, който връща true or false на дадени критерии
Predicate<int> match;

if (isEven)
{
    match = number => number % 2 == 0;
}
else
{
    match = number => (number % 2 != 0);
}

List<int> result = new();

foreach (int number in numbers)
{
    if (!(match(number)))
    {
        continue;
    }
        result.Add(number);
}
Console.WriteLine(String.Join(" ", result));