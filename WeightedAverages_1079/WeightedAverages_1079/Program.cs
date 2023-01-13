using System;

namespace WeightedAverages_1079
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

            
            String[] values = Console.ReadLine().Split();
            double value0 = double.Parse(values[0]);
            double value1 = double.Parse(values[1]);
            double value2 = double.Parse(values[2]);

            double average = (value0 * 2 + value1 * 3 + value2 * 5) / 10;

            Console.WriteLine($"{average:F1}");

            }

        }
    }
}

