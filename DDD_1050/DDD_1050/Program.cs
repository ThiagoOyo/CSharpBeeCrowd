using System;

namespace DDD_1050
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int codeNumber = int.Parse(Console.ReadLine());

            if (codeNumber == 61)
            {
                Console.WriteLine("Brasilia");
            } else if (codeNumber == 71)
            {
                Console.WriteLine("Salvador");
            } else if (codeNumber == 11)
            {
                Console.WriteLine("Sao Paulo");
            } else if (codeNumber == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            } else if (codeNumber == 32)
            {
                Console.WriteLine("Juiz de Fora");
            } else if (codeNumber == 19)
            {
                Console.WriteLine("Campinas");
            } else if (codeNumber == 27)
            {
                Console.WriteLine("Vitoria");
            } else if (codeNumber == 31)
            {
                Console.WriteLine("Belo Horizonte");
            } else
            {
                Console.WriteLine("DDD nao cadastrado");
            }






        }
    }
}

