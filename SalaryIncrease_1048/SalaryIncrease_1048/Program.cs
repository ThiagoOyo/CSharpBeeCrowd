using System;

namespace SalaryIncrease_1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double moneyEarned = 0;
            double newSalary = 0;
            int percentage = 0;

            if (salary > 0.00 && salary <= 400.00)
            {
                newSalary = salary + (salary * 15 / 100);
                moneyEarned = newSalary - salary;
                percentage = 15;
            } else if (salary > 400.00 && salary <= 800.00)
            {
                newSalary = salary + (salary * 12 / 100);
                moneyEarned = newSalary - salary;
                percentage = 12;
            } else if (salary > 800.00 && salary <= 1200.00)
            {
                newSalary = salary + (salary * 10 / 100);
                moneyEarned = newSalary - salary;
                percentage = 10;
            } else if (salary > 1200.00 && salary <=2000.00)
            {
                newSalary = salary + (salary * 7 / 100);
                moneyEarned = newSalary - salary;
                percentage = 7;
            } else if (salary > 2000.00)
            {
                newSalary = salary + (salary * 4 / 100);
                moneyEarned = newSalary - salary;
                percentage = 4;
            }

            Console.WriteLine($"Novo salario: {newSalary:F2}");
            Console.WriteLine($"Reajuste ganho: {moneyEarned:F2}");
            Console.WriteLine($"Em percentual: {percentage} %");


        }
    }
}

