using System;

namespace DividingXByY_1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                String[] values = Console.ReadLine().Split();
                double x = double.Parse(values[0]);
                double y = double.Parse(values[1]);

                if (y == 0) 
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    Console.WriteLine($"{x / y:F1}");
                }


            }




        }
    }
}

