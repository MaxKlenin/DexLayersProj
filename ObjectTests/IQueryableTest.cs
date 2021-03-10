using Object;
using NUnit.Framework;
using System;
using System.Linq;

namespace ObjectTests
{
    public class IQueryableTest
    {
        private Doge[] dogs;
        private string[] dogeNames = { "Акита-ину", "Аляскинский Маламут", "Американская Акита",
            "Бигль", "Бладхаунд", "Бобтейл", "Боксер", "Босерон",
            "Немецкая овчарка", "Немецкий дог", "Ньюфаундленд"};

        private void GenerateDogs()
        {
            var rand = new Random();
            dogs = new Doge[100];
            for (int i = 0; i < 100; i++)
            {
                int rndIndex = rand.Next(dogeNames.Length);
                int rndWeight = rand.Next(1, 51);
                int day = rand.Next(1, 29);
                int month = rand.Next(1, 13);
                int year = rand.Next(2015, 2021);
                bool randomBool = rand.Next(0, 2) > 0;
                dogs[i] = new Doge(dogeNames[rndIndex], rndWeight,
                    new DateTime(year, month, day), randomBool);
            }
        }

        [SetUp]
        public void Setup()
        {
            GenerateDogs();
        }

        [Test]
        public void WhereAndOrderBySamplingTest()
        {
            Console.WriteLine("***(Where) Породы собак начаниются на букву Б ***");
            var selectedDogeName = dogs.Where(d => d.Name.ToUpper().StartsWith("Б")).OrderBy(d => d.Name);
            foreach (var item in selectedDogeName)
            {
                Console.WriteLine(item.Name);
            }
        }
        
        [Test]
        public void GroupBySamplingTest()
        {
            Console.WriteLine("***(GroupBy) Кол-во собак каждой породы: ***");
            var dogeGroups = dogs.GroupBy(d => d.Name).Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var group in dogeGroups)
            {
                Console.WriteLine($"{group.Name}: {group.Count}");
            }
        }

        [Test]
        public void MinMaxSumSamplingTest()
        {
            int minNameLenght = dogs.Min(d => d.Name.Length);
            int maxNameLenght = dogs.Max(d => d.Name.Length);
            Console.WriteLine($"Минимальное кол-во символов в название породы собаки: {minNameLenght}" +
                $"\nМаксимальное кол-во символов в название породы собаки: {maxNameLenght}");
            int sumVaccinated = dogs.Sum(d => Convert.ToInt32(d.IsVaccinated));
            Console.WriteLine($"Общее кол-во привитых собак: {sumVaccinated}");
        }

        [Test]
        public void AnyAllSamplingTest()
        {
            Console.WriteLine("***(AnyAll) Выборки по возрасту***");
            var dogeSampling = dogs.All(d => d.Time.Year < 2019);

            if (dogeSampling)
            {
                Console.WriteLine("Все собаки родились до 2019 года");
            }
            else
            {
                Console.WriteLine("Не все собаки родились до 2019 года");
            }

            dogeSampling = dogs.Any(d => d.Time.Year == 2020);

            if (dogeSampling)
            {
                Console.WriteLine("Хотя бы одна собака родилась в 2020 году");
            }
            else
            {
                Console.WriteLine("В 2020 году собаки не родились");
            }
        }
    }
}