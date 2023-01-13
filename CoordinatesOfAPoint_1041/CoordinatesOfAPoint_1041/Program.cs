using System;

namespace CoordinatesOfAPoint_1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] values = Console.ReadLine().Split();
            float x = float.Parse(values[0]);
            float y = float.Parse(values[1]);

             if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            } else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            } else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }

        

        }
    }
}

