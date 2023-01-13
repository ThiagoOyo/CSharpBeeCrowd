using System;

namespace SelectionTest1_1035
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(); 
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
            int c = int.Parse(values[2]);
            int d = int.Parse(values[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
              Console.WriteLine("Valores aceitos");
            } else 
            { 
                Console.WriteLine("Valores nao aceitos");
            }
                   




        }
    }
}

