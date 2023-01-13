using System;

namespace Average3_1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(); 
            double n1 = double.Parse(values[0]);
            double n2 = double.Parse(values[1]);
            double n3 = double.Parse(values[2]);
            double n4 = double.Parse(values[3]);
            double average = Math.Round(((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10, 1);
            Console.WriteLine($"Media: {average:F1}");
            if (average > 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } else if (average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            } else if (average >= 5.0 && average < 7.0)
            {
                Console.WriteLine("Aluno em exame.");
                double n5 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {n5:F1}");
                double newAverage = (average + n5) / 2;
                if (newAverage >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {newAverage:F1}");
                } else if (newAverage < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {newAverage:F1}");
                }
            }



        }
    }
}

