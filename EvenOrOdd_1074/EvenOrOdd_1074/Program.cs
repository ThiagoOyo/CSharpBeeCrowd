using System;

namespace EvenOrOdd_1074
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i, value;
            String[] valueArray = new string[n];

            for (i = 0; i < n; i++)
            {
                value = int.Parse(Console.ReadLine());

                if (value > 0 && value % 2 == 0)
                {
                   valueArray[i] = "EVEN POSITIVE";
                }
                else if (value > 0 && value % 2 == 1)
                {
                    valueArray[i] = "ODD POSITIVE";
                }
                else if (value < 0 && value % 2 == 0)
                {
                    valueArray[i] = "EVEN NEGATIVE";
                }
                else if (value < 0 && value % 2 != 0)
                {
                    valueArray[i] = "ODD NEGATIVE";
                }
                else if (value == 0)
                {
                    valueArray[i] = "NULL";
                }
            }
            
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(valueArray[i]);
            }




        }
    }
}

