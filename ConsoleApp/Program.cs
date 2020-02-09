using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            InsertMultipleSamurais();
            GetSamurais("After Add:");
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void InsertMultipleSamurais()
        {
            var samurai = new Samurai { Name = "Bernie" };
            var samurai2 = new Samurai { Name = "Charlie" };
            var samurai3 = new Samurai { Name = "Seth" };
            var samurai4 = new Samurai { Name = "Natalie" };
            context.Samurais.AddRange(samurai, samurai2);

            context.SaveChanges();
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Bernie" };
            context.Samurais.Add(samurai);
            context.SaveChanges();

        }

        private static void GetSamuraisSimpler()
        {
            //var samurais = context.Samurais.ToList();
            var query = context.Samurais;
            var samurais = query.ToList();
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
