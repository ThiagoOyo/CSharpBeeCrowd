using System;

namespace SixOddNumbers_1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int count = 0;
            int x = int.Parse(Console.ReadLine());

            for (i = x; count < 6; i++)
            {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                        count++;
                    }
                }
            





        }
    }
}

