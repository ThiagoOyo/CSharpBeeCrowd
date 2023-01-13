using System;

namespace SumOfConsecutiveOddNumbers1_1071
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int min = 0;
            int max = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;

            if (x < y)
            {
                min = x;
                max = y;
            } else 
            {
                max = x;
                min = y;
            }

            for (i = min + 1; i < max; ++i)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

