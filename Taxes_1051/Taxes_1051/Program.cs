using System;

namespace Taxes_1051
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double taxes2000 = 0;
            double currentSalary = salary;
            double taxes3000 = 0;
            double taxes4500 = 0;
            double taxes = 0;

            if (salary > 0.00 && salary < 2000.00)
            {
                Console.WriteLine("Isento");
            } else if (salary > 2000.00 && salary <= 3000.00){
                taxes = (salary - 2000) * 8 / 100;
                Console.WriteLine($"R$ {taxes:F2}");

            } else if (salary > 3000.00 && salary <= 4500.00)
            {
                taxes3000 = 1000 * 8 / 100;
                taxes = taxes3000 + (salary - 3000) * 18 / 100;
                Console.WriteLine($"R$ {taxes:F2}");
            } else if (salary > 4500.00)
            {
                taxes3000 = 1000 * 8 / 100;
                taxes4500 = 1500 * 18 / 100;
                taxes = taxes3000 + taxes4500 + (salary - 4500) * 28 / 100;
                Console.WriteLine($"R$ {taxes:F2}");
            }

            


        }
    }
}

