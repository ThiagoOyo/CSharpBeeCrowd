using System;

namespace Interval2_1072
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countIn = 0;
            int countOut= 0;

            for (int i = 0; i < n; i++) {
                int value = int.Parse(Console.ReadLine());
                if (value >= 10 && value <= 20) {
                    countIn++;
                } else
                {
                    countOut++;
                }
            }

            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");

        }
    }
}

