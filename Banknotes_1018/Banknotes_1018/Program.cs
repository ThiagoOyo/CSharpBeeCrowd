using System;

namespace Banknotes_1018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalValue = int.Parse(Console.ReadLine());

            int notas100 = totalValue / 100;
            int value = totalValue - notas100 * 100;

            int notas50 = value / 50;
            value -= notas50 * 50;

            int notas20 = value / 20;
            value -= notas20 * 20;

            int notas10 = value / 10;
            value -= notas10 * 10;

            int notas5 = value / 5;
            value -= notas5 * 5;

            int notas2 = value / 2;
            value -= notas2 * 2;

            int notas1 = value / 1;
            value -= notas1 * 1;

            Console.WriteLine(totalValue);
            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1} nota(s) de R$ 1,00");



        }
    }
}

