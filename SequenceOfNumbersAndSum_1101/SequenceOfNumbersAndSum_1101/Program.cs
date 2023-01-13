using System;

namespace SequenceOfNumbersAndSum_1101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int m = 1;
            int n = 1;
            int max = 0;
            int min = 0;
            int sum = 0;

            

            

            while (true)

            {
                String[] values = Console.ReadLine().Split();
                m = int.Parse(values[0]);
                n = int.Parse(values[1]);

                if (n <= 0 || m <= 0)
                {
                    break;
                }

                if (n > m)
                {
                    max = n;
                    min = m;
                }
                else
                {
                    max = m;
                    min = n;
                }

                for (int i = min; i<= max; i++)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={sum}");
                sum = 0;
                
            } 
            



        }
    }
}

