using System;

namespace ScoreValidation_1117
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0.0;
            double scoreValidation = 0.0;
            int count = 0;


            while(count < 2)
            {
                scoreValidation = double.Parse(Console.ReadLine());

                if (scoreValidation >= 0.0 && scoreValidation <= 10.0)
                {
                    sum += scoreValidation;
                    count++;
                } else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            double average = sum / 2;
            Console.WriteLine($"media = {average:F2}");

        }
    }
}

