using System;

namespace Average1_1005
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double average = (a * 3.5 + b * 7.5) / (3.5 + 7.5);
            Console.WriteLine($"MEDIA = {average:F5}");


        }
    }
}

