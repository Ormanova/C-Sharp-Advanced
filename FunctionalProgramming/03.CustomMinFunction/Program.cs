


using System.Linq;

int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Func<int[], int> print = number =>
 {
     int smallestNumber = int.MaxValue;
     foreach (var n in numbers)
     {
         if (n < smallestNumber)
         {
             smallestNumber = n;
         }
     }
     return smallestNumber;
 };

Console.WriteLine(print(numbers));