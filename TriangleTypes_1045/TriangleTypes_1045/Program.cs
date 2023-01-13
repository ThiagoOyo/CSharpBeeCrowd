using System;

namespace TriangleTypes_1045
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] values = Console.ReadLine().Split();
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);
            double temp;

            if (b > a && b > c)
            {
                temp = a;
                a = b;
                b = temp;
            } else if (c > a && c > b)
            {
                temp = a;
                a = c;
                c = temp;
            }

            if (b < c)
            {
                temp = c;
                c = b;
                b = temp;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a * a == (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (a * a > (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (a * a < (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if (a == b && c != a)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                if (c == b && c != a)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}

