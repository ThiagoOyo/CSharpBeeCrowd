using System;

namespace Area_1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            double triangleRect = (a * c)/2;
            double areaCircle = 3.14159 * (c * c);
            double areaTrapezium = (1.0 / 2) * c * (a + b);
            double areaSquare = b * b;
            double areaRectangle = a * b;
            Console.WriteLine($"TRIANGULO: {triangleRect:F3}");
            Console.WriteLine($"CIRCULO: {areaCircle:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezium:F3}");
            Console.WriteLine($"QUADRADO: {areaSquare:F3}");
            Console.WriteLine($"RETANGULO: {areaRectangle:F3}");





        }
    }
}

