using System;
using System.Runtime.CompilerServices;

namespace Quadrant_1115
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int x = 1;
            int y = 2;

            while (x != 0)
            {
                String[] values = Console.ReadLine().Split();
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);

                if (y == 0)
                {
                    break;
                }

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                } else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
            }




        }
    }
}

