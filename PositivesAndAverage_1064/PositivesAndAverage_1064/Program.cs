using System;

namespace PositiveNumbers_1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int count = 0;
            double[] numbers = new double[6];
            double[] positiveNumbers = new double[6];


            for (i = 0; i < 6; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] > 0)
                {
                    count++;
                    positiveNumbers[i] = numbers[i];                    
                }
            }

            double average = (positiveNumbers[0] + positiveNumbers[1] + positiveNumbers[2] + positiveNumbers[3] + positiveNumbers[4] + positiveNumbers[5]) / count;
            Console.WriteLine($"{count} valores positivos");
            Console.WriteLine($"{average:F1}");



        }
    }
}

