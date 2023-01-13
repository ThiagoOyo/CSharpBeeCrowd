using System;

namespace Salary_1008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            float receivedPerHour = float.Parse(Console.ReadLine());
            float salary = receivedPerHour * workedHours; 
            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary:F2}");




        }
    }
}

