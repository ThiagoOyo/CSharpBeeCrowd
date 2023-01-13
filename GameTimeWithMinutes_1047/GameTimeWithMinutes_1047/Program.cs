using System;

namespace teste1047
{
    public class Program
    {
        public static void Main(string[] args)
        {

            String[] values = Console.ReadLine().Split();
            int startTimeHour = int.Parse(values[0]);
            int startTimeMinute = int.Parse(values[1]);
            int endTimeHour = int.Parse(values[2]);
            int endTimeMinute = int.Parse(values[3]);
            int hDiff, mDiff;

            if (endTimeHour > startTimeHour || (endTimeHour == startTimeHour && endTimeMinute > startTimeMinute))
            {
                hDiff = endTimeHour - startTimeHour;
            }
            else
            {
                hDiff = (endTimeHour - startTimeHour) + 24;
            }

            if (endTimeMinute < startTimeMinute)
            {
                hDiff -= 1;
                mDiff = (endTimeMinute - startTimeMinute) + 60;
            }
            else
            {
                mDiff = endTimeMinute - startTimeMinute;
            }

            Console.WriteLine($"O JOGO DUROU {hDiff} HORA(S) E {mDiff} MINUTO(S)");

        }
    }
}

