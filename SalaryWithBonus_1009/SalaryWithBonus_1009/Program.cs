using System;

namespace SalaryWithBonus_1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sellerName = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double totalSales = double.Parse(Console.ReadLine());
            double bonus = totalSales * 15 / 100;
            double salaryWithBonus = salary + bonus;
            Console.WriteLine($"TOTAL = R$ {salaryWithBonus:F2}");





        }
    }
}

