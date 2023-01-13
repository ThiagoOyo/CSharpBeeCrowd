using System;


namespace GameTime_1046
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] values = Console.ReadLine().Split();
            int startTime = int.Parse(values[0]);
            int endTime = int.Parse(values[1]);
            int x = 24;

            if (startTime > endTime)
            {
                x = x - startTime + endTime;
            } else if (startTime < endTime)
            {
                x = endTime - startTime;
            } else if (endTime == startTime)
            {
                x = 24;
            }
    

            Console.WriteLine($"O JOGO DUROU {x} HORA(S)");




        }
    }
}

