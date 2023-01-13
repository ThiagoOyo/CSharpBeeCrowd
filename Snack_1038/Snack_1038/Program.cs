using System;

namespace Snack_1038
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
            double total;

            if (x == 1)
            {
                total = y * 4.00;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (x == 2)
            {
                total = y * 4.50;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (x == 3)
            {
                total = y * 5.00;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (x == 4)
            {
                total = y * 2.00;
                Console.WriteLine($"Total: R$ {total:F2}");
            } else if (x == 5)
            {
                total = y * 1.50;
                Console.WriteLine($"Total: R$ {total:F2}");
            }




        }
    }
}

