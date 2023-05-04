

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
 int divider = int.Parse(Console.ReadLine());

Func<List<int>, List<int>> reversed = numbers =>
{
    List<int> result = new List<int>();
    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }
    return result;
};

Func<List<int>, Predicate<int>, List<int>> moderationList = (numbers, divisible) =>
 {
     List<int> result = new List<int>();
     foreach (var number in numbers)
     {
         if (!divisible(number))
         {
             result.Add(number);
         }
     }
     return result;
 };

numbers = moderationList(numbers, n => n % divider == 0);
numbers = reversed(numbers);

Console.WriteLine(String.Join(" ", numbers));
