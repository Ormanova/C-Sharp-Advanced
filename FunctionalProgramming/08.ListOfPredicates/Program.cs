

List<Predicate<int>> predicates = new List<Predicate<int>>();
int end = int.Parse(Console.ReadLine());
HashSet<int> dividers = Console.ReadLine().Split( " ").Select(int.Parse).ToHashSet();
List<int> numbers = Enumerable.Range(1, end).ToList();




foreach (var divider in dividers)
{
    predicates.Add(p => p % divider == 0);
}

foreach (var number in numbers)
{
    bool IsDivisible = true; // predicates.All(match => match(number))
                             // 
    foreach (var match in predicates)
    {
        if (!match(number))
        {
            IsDivisible = false;
            break;
        }
    }
    if (IsDivisible)
    {
        Console.Write($"{number} ");
    }
}

