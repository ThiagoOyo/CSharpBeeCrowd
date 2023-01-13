using System;

namespace EvenOddPositiveNegative_1066
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int countEven = 0;
            int countOdd = 0;
            int countPositive = 0;
            int countNegative = 0;
            int[] numbers = new int[5];

            for (i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    countEven++;
                }
                if (numbers[i] % 2 != 0)
                {
                    countOdd++;
                }
                if (numbers[i] > 0)
                {
                    countPositive++;
                }
                if (numbers[i] < 0)
                {
                    countNegative++;
                }
            }

            Console.WriteLine($"{countEven} valor(es) par(es)");
            Console.WriteLine($"{countOdd} valor(es) impar(es)");
            Console.WriteLine($"{countPositive} valor(es) positivo(s)");
            Console.WriteLine($"{countNegative} valor(es) negativo(s)");
        }
    }
}

