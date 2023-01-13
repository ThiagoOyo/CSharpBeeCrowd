using System;

namespace Consumption_1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            float fuelSpent = float.Parse(Console.ReadLine());
            float averageConsumption = distance / fuelSpent;
            Console.WriteLine($"{averageConsumption:F3} km/l");




        }
    }
}

