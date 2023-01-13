using System;

namespace EvenSquare_1073
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int n = int.Parse(Console.ReadLine());

            for (i=1; i<=n; i++) {
                if (i % 2 == 0)
                {
                    int iSquare = i * i;
                    Console.WriteLine($"{i}^{2} = {iSquare}");
                }
            }
            


        }
    }
}

