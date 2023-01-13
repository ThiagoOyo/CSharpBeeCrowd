using System;
using System.Globalization;

namespace CircleArea_1002
{

    public class Program
    {
        public static void Main()
        {

            double R = double.Parse(Console.ReadLine());
            double A = 3.14159 * Math.Pow(R, 2);
            Console.WriteLine($"A={A:F4}");


        }

    }

}