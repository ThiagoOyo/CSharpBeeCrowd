using System;
using System.Xml.Serialization;

namespace Grenais_1131
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice = 1;
            int grenaisCount = 0;
            int gremioWinCount = 0;
            int interWinCount = 0;
            int draws = 0;



            do
            {
                String[] goals = Console.ReadLine().Split();
                int goalInter = int.Parse(goals[0]);
                int goalGremio = int.Parse(goals[1]);
                grenaisCount++;

                

                if (goalInter > goalGremio)
                {
                    interWinCount++;
                } else if (goalGremio > goalInter)
                {
                    gremioWinCount++;
                } else if (goalInter == goalGremio)
                {
                    draws++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                choice = int.Parse(Console.ReadLine());

                if (choice == 2)
                {
                    break;
                }
            } while (choice == 1);

            Console.WriteLine($"{grenaisCount} grenais");
            Console.WriteLine($"Inter:{interWinCount}");
            Console.WriteLine($"Gremio:{gremioWinCount}");
            Console.WriteLine($"Empates:{draws}");

            if (interWinCount > gremioWinCount)
            {
                Console.WriteLine("Inter venceu mais");
            } else if (gremioWinCount > interWinCount)
            {
                Console.WriteLine("Gremio venceu mais");
            } else if (gremioWinCount == interWinCount)
            {
                Console.WriteLine("Não houve vencedor");
            }

        }
    }
}

