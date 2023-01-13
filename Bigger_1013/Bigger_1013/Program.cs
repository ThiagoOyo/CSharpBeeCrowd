using System;

namespace Bigger_1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split();

            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);   
            int numero3 = int.Parse(numeros[2]);

            int maior = (numero1 + numero2 + Math.Abs(numero1 - numero2)) / 2;
            maior = (maior + numero3 + Math.Abs(maior - numero3)) / 2;

            Console.WriteLine($"{maior} eh o maior");

        }
    }
}