using System;
using System.Globalization;

namespace XValue_2
{

    public class Program
    {
        public static void Main()
        {


            Console.WriteLine("What is the value of A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the value of B: ");
            int B = int.Parse(Console.ReadLine());
            int X = A + B;
            Console.WriteLine($"X = {X}");


        }

    }

}