

int length = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine().Split(" ").ToList();

Func<List<string>, Predicate<string>, List<string>> filterNmaes = (names, filter) =>
{
    List<string> list = new List<string>();
    foreach (var name in names)
    {
        if (filter(name))
        {
            list.Add(name);
        }
    }
    return list;
};

names = filterNmaes(names, n => n.Length <= length);

Console.WriteLine(String.Join(Environment.NewLine, names));