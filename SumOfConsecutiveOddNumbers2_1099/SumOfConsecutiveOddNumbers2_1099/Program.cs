using System;

namespace SumOfConsecutiveOddNumbers2_1099
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;

            for (int i = 0; i < n; i++)
            {
                String[] values = Console.ReadLine().Split();
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);
                int sum = 0;
                

                if (x < y)
                {
                    min = x;
                    max = y;
                } else 
                {
                    min = y;
                    max = x;
                }

                for  (int j = min + 1; j < max; j++)
                {
                    if (j % 2 == 1)
                    {
                       sum += j;  
                    }
                        
            
                }

                Console.WriteLine($"{sum}");
            }




        }
    }
}

