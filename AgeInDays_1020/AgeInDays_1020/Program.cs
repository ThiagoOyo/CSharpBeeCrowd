using System;

namespace AgeInDays_1020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            int ageYear = age / 365;
            age -= ageYear * 365;

            int ageMonth = age / 30; 
            age -= ageMonth * 30;

            int ageDay = age;
            age -= ageDay;

            Console.WriteLine($"{ageYear} ano(s)");
            Console.WriteLine($"{ageMonth} mes(es)");
            Console.WriteLine($"{ageDay} dia(s)");



        }
    }
}

