using System;

namespace DistanceBetweenTwoPoints_1015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] x = Console.ReadLine().Split();
            String[] y = Console.ReadLine().Split();
            double x1 = Double.Parse(x[0]);
            double x2 = Double.Parse(y[0]);
            double y1 = Double.Parse(x[1]);
            double y2 = Double.Parse(y[1]);
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{distance:F4}");




        }
    }
}

