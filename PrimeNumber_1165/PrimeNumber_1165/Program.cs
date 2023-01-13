using System;

namespace PrimeNumber_1165
{
    public class Program
    {
        static bool isPrime(int value)
        {
            if (value == 1) return false;
            for (int i = 2; i < value; i++) {
                if (value % 2 == 0) return false;
            }
            
            return true;
        }
        public static void Main(string[] args)
        {

            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string answer = $"{number} ";

                if (!isPrime(number)) answer += "nao ";
                answer += "eh primo";
                Console.WriteLine(answer);
            }




        }
    }
}

