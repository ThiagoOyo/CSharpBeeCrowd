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


            for (i=0 ; i<6; i++) {
               numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] > 0 )
                {
                   count++;
                }
            }

            Console.WriteLine($"{count} valores positivos");


             
        }
    }
}

