string[] names = Console.ReadLine().Split(' ');

Action<string[]> print = (names) => Console.WriteLine(string.Join(Environment.NewLine, names));

print(names);