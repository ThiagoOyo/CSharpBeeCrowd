using System;

namespace Interval_1037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 0.00 && number <= 100.00)
            {
                if (number >= 0.00 && number <= 25.00)
                {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if (number > 25.00 && number <= 50.00)
                {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if (number > 50.00 && number <= 75.00)
                {
                    Console.WriteLine("Intervalo (50,75]");
                }
                else if (number > 75.00 && number <= 100.00)
                {
                    Console.WriteLine("Intervalo (75,100]");
                }
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}

