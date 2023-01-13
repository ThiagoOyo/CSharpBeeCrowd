using System;

namespace Experiments_1094
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rabbits = 0;
            int rats = 0;
            int frogs = 0;

            for (int i = 1; i <= n; i++)
            {
                String[] animals = Console.ReadLine().Split();
                int quantity = int.Parse(animals[0]);
                string animal = animals[1];
                if (animal == "C")
                {
                    rabbits += quantity;
                } else if (animal == "R")
                {
                    rats += quantity;
                } else if (animal == "S")
                {
                    frogs += quantity;
                }
            }

            int totalcount = rabbits + rats + frogs;

            Console.WriteLine($"Total: {totalcount} cobaias");
            Console.WriteLine($"Total de coelhos: {rabbits}");
            Console.WriteLine($"Total de ratos: {rats}");
            Console.WriteLine($"Total de sapos: {frogs}");
            Console.WriteLine($"Percentual de coelhos: {100.00 * rabbits / totalcount:F2} %");
            Console.WriteLine($"Percentual de ratos: {100.00 * rats / totalcount:F2} %");
            Console.WriteLine($"Percentual de sapos: {100.00 * frogs / totalcount:F2} %");


        }
    }
}

