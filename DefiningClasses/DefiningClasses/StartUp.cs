using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> peopleOver30 = new List<Person>();
            for (int i = 1; i <= n; i++)
            {
                string[] tockens = Console.ReadLine().Split(" ");
                string name = tockens[0];
                int age = int.Parse(tockens[1]);

                Person person = new Person(name, age);
                if (person.Age > 30)
                {
                    peopleOver30.Add(person);
                }

            }
            List<Person> orderedList = peopleOver30.OrderBy(p => p.Name).ToList();
            foreach (var person in orderedList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
