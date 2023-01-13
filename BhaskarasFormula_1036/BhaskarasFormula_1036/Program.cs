using System;

namespace BhaskarasFormula_1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);

            double valueSqrt = (b * b) - (4 * (a) * (c));

            if (a != 0 && valueSqrt > 0) {
                valueSqrt = Math.Sqrt(valueSqrt);
                double x = (-b + valueSqrt) / (2 * a);
                double y = (-b - valueSqrt) / (2 * a);
                Console.WriteLine($"R1 = {x:F5}");
                Console.WriteLine($"R2 = {y:F5}");
            } else
            {
                Console.WriteLine("Impossivel calcular");
            }



        }
    }
}

