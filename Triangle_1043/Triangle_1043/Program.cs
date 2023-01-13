using System;

namespace Triangle_1043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] values = Console.ReadLine().Split();
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);
            double perimeter, area;

            if (a + b > c && c + a > b && c + b > a)
            {
                perimeter = a + b + c;
                Console.WriteLine($"Perimetro = {perimeter:F1}");
            } else { 
                area = (a + b) * (0.5 * c);
                Console.WriteLine($"Area = {area:F1}");
            }


        }
    }
}

