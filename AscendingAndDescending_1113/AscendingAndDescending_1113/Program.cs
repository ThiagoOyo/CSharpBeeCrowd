using System;

namespace AscendingAndDescending_1113
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            while (x != y)
            {
                String[] values = Console.ReadLine().Split();
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);

                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                } else if (y > x) 
                {
                    Console.WriteLine("Crescente");
                }
            }
            



        }
    }
}

