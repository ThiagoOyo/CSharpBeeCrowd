using System;

namespace SimpleCalculate_1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] array1 = Console.ReadLine().Split();
            String[] array2 = Console.ReadLine().Split();
            double valueProdA = int.Parse(array1[1]) * double.Parse(array1[2]);
            double valueProdB = int.Parse(array2[1]) * double.Parse(array2[2]);
            double amount = valueProdA + valueProdB;
            Console.WriteLine($"VALOR A PAGAR: R$ {amount:F2}");


        }
    }
}

