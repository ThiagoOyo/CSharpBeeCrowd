using System;

namespace SequenceIJ3_1097
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i=1; i<=9; i += 2)
            {
                for (int j = 6 + i; j >= 4 + i; j -= 1)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }



        }
    }
}

