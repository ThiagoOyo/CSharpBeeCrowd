using System;

namespace OddNumbers_1067
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int x = int.Parse(Console.ReadLine());

            for (i=1; i<x+1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}

