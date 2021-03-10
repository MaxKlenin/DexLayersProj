using Object;
using NUnit.Framework;
using System;
using System.Linq;

namespace ObjectTests
{
    public class IQueryableTest
    {
        private Doge[] dogs;
        private string[] dogeNames = { "�����-���", "����������� �������", "������������ �����",
            "�����", "���������", "�������", "������", "�������",
            "�������� �������", "�������� ���", "������������"};

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
            Console.WriteLine("***(Where) ������ ����� ���������� �� ����� � ***");
            var selectedDogeName = dogs.Where(d => d.Name.ToUpper().StartsWith("�")).OrderBy(d => d.Name);
            foreach (var item in selectedDogeName)
            {
                Console.WriteLine(item.Name);
            }
        }
        
        [Test]
        public void GroupBySamplingTest()
        {
            Console.WriteLine("***(GroupBy) ���-�� ����� ������ ������: ***");
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
            Console.WriteLine($"����������� ���-�� �������� � �������� ������ ������: {minNameLenght}" +
                $"\n������������ ���-�� �������� � �������� ������ ������: {maxNameLenght}");
            int sumVaccinated = dogs.Sum(d => Convert.ToInt32(d.IsVaccinated));
            Console.WriteLine($"����� ���-�� �������� �����: {sumVaccinated}");
        }

        [Test]
        public void AnyAllSamplingTest()
        {
            Console.WriteLine("***(AnyAll) ������� �� ��������***");
            var dogeSampling = dogs.All(d => d.Time.Year < 2019);

            if (dogeSampling)
            {
                Console.WriteLine("��� ������ �������� �� 2019 ����");
            }
            else
            {
                Console.WriteLine("�� ��� ������ �������� �� 2019 ����");
            }

            dogeSampling = dogs.Any(d => d.Time.Year == 2020);

            if (dogeSampling)
            {
                Console.WriteLine("���� �� ���� ������ �������� � 2020 ����");
            }
            else
            {
                Console.WriteLine("� 2020 ���� ������ �� ��������");
            }
        }
    }
}