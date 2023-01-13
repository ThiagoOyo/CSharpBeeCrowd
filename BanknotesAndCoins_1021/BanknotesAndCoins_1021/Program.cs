using System;

namespace BanknotesAndCoins_1021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double totalValue = float.Parse(Console.ReadLine());

            int notas100 = (int) totalValue / 100;
            double value = totalValue - notas100 * 100;

            int notas50 = (int) value / 50;
            value -= notas50 * 50;

            int notas20 = (int) value / 20;
            value -= notas20 * 20;

            int notas10 = (int) value / 10;
            value -= notas10 * 10;

            int notas5 = (int) value / 5;
            value -= notas5 * 5;

            int notas2 = (int) value / 2;
            value -= notas2 * 2;

            int notas1 = (int) value / 1;
            value -= notas1 * 1;

            int moedas50 = (int)(value / 0.5);
            value -= (moedas50 * 0.5);

            int moedas25 = (int)(value / 0.25);
            value -= (moedas25 * 0.25);

            int moedas10 = (int)(value / 0.1);
            value -= (moedas10 * 0.1);

            int moedas5 = (int)(value / 0.05);
            value -= (moedas5 * 0.05);

            int moedas1Cent = (int)Math.Round(value / 0.01);
            value -= (moedas1Cent * 0.01);


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{notas100} nota(s) de R$ 100.00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50.00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20.00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10.00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5.00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{notas1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moedas50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moedas25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moedas10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moedas5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moedas1Cent} moeda(s) de R$ 0.01");

        }
    }
}

