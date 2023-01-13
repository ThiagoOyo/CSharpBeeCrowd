using System;

namespace Sphere_1011
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double sphereVolume = (4.0 / 3) * 3.14159 * Math.Pow(radius, 3);
            Console.WriteLine($"VOLUME = {sphereVolume:F3}");




        }
    }
}

