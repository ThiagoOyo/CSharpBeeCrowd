using System;

namespace Fliper_2452
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();

            int p = int.Parse(values[0]);
            int r = int.Parse(values[1]);

            if (p == 0)
            {
                Console.WriteLine("C");
            } else if (r == 0) {
                Console.WriteLine("B");
            } else
            {
                Console.WriteLine("A");
            }




        }
    }
}

