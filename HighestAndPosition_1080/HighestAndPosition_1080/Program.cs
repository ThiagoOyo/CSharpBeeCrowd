using System;

namespace HighestAndPosition_1080
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int biggerValue = 0;
            int biggerPosition = 0;


            for (int i = 1; i <= 100; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value > biggerValue)
                {
                    biggerValue = value;
                    biggerPosition = i;
                }
            }

            Console.WriteLine(biggerValue);
            Console.WriteLine(biggerPosition);

        }
    }
}

