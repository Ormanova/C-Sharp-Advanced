using System;

namespace PokemonTrainer;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();
       

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] tockens = input.Split(" ");
            Trainer trainer = trainers.SingleOrDefault(t => t.Name == tockens[0]);

            if (trainer == null)
            {
                trainer = new Trainer(tockens[0]);
                trainer.Pokemons.Add(new(tockens[1], tockens[2], int.Parse(tockens[3])));
                trainers.Add(trainer);
            }
            else
            {
                trainer.Pokemons.Add(new(tockens[1], tockens[2], int.Parse(tockens[3])));
            }
        }
        string input2 = string.Empty;
        while ((input2 = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                trainer.CheckElement(input2);
            }

        }
        foreach (var trainer in trainers.OrderByDescending(t =>  t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}