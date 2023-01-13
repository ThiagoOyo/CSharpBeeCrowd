using System;
using System.Security.Cryptography.X509Certificates;

namespace SeveralScoresWithValidation_1118
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0.0;
            int count = 0;
            int x = 1;


            while (x == 1)
            {
                

                while (count < 2)
                {
                    
                    double scoreValidation = double.Parse(Console.ReadLine());

                    if (scoreValidation >= 0.0 && scoreValidation <= 10.0)
                    {
                        sum += scoreValidation;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }

                
                double average = sum / 2;
                Console.WriteLine($"media = {average:F2}");
                count = 0;
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());
                sum = 0;

                if (x == 2)
                {
                    break;
                } 
                
                while ((x!= 1) && (x != 2)) 
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                }



            } 
        }
    }
}

