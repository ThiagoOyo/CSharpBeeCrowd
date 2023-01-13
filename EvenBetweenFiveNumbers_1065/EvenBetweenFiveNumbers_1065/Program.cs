using System;

namespace EvenBetweenFiveNumbers_1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int count = 0;
            int[] numbers = new int[5];

            for (i=0; i<5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    count++;
                } 
            }

            Console.WriteLine($"{count} valores pares");


        }
    }
}

