using System;

namespace MultiplesOf13_1132
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

         
            if (start > end)
            {
                int aux = start;
                start = end;
                end = aux;
            }

            int soma = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
                
            }

            Console.WriteLine(soma);
            
            
            
            
            
            
            
            


        }
    }
}

