using System;

namespace SimpleSort_1042
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] values = Console.ReadLine().Split();
            int n1 = int.Parse(values[0]);
            int n2 = int.Parse(values[1]);
            int n3 = int.Parse(values[2]);
            int maior;
            int menor = 0;

            maior = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
            maior = (maior + n3 + Math.Abs(maior - n3)) / 2;

            
            if (n1 < n2)
            {
                menor = n1; 
            } else if (n2 < n1)
            {
                menor = n2;
            }

            if (n3 < menor)
            {
                menor = n3;
            }

            Console.WriteLine(menor);
            if (n1 > menor && n1 < maior)
            {
                Console.WriteLine(n1);
            } else if (n2 > menor && n2 < maior)
            {
                Console.WriteLine(n2);
            } else if (n3 > menor && n3 < maior)
            {
                Console.WriteLine(n3);
            }
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);





        }
    }
}

