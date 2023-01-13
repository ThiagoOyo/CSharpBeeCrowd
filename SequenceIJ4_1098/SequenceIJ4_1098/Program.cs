using System;

namespace SequenceIJ4_1098
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double i = 0;

            while (i <= 2)
            {
                Console.WriteLine($"I={i} J={i + 1}");
                Console.WriteLine($"I={i} J={i + 2}");
                Console.WriteLine($"I={i} J={i + 3}");

                i += 0.2;
            }


        }
    }
}

