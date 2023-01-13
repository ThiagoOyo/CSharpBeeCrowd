using System;

namespace TimeConversion_1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nHours = n / 3600;
            n -= nHours * 3600;

            int nMinutes = n / 60;
            n -= nMinutes * 60;

            int nSeconds = n / 1;
            n -= nSeconds;

            Console.WriteLine($"{nHours}:{nMinutes}:{nSeconds}");

        }
    }
}

