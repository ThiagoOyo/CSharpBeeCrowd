using System;

namespace SequenceIJ2_1096
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i=1; i<=9; i += 2)
            {
                for (int j=7; j>4; --j) 
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }



        }
    }
}

