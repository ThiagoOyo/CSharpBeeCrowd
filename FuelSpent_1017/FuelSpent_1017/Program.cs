using System;

namespace FuelSpent_1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timeSpent = int.Parse(Console.ReadLine());
            int averageSpeed = int.Parse(Console.ReadLine());
            double totalkm = averageSpeed * timeSpent;
            double liters = totalkm / 12;
            Console.WriteLine($"{liters:F3}");




        }
    }
}

