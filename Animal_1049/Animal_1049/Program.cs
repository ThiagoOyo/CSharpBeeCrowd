using System;

namespace Animal_1049
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string vertebrado = Console.ReadLine();
            string tipo = Console.ReadLine();
            string carnivoro = Console.ReadLine();

            if (vertebrado == "vertebrado")
            {
                if (tipo == "ave")
                {
                    if (carnivoro == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } else if (carnivoro == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                } else if (tipo == "mamifero")
                {
                    if (carnivoro == "onivoro")
                    {
                        Console.WriteLine("homem");
                    } else if (carnivoro == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    } 
                }
            } else if (vertebrado == "invertebrado")
            {
                if (tipo == "inseto")
                {
                    if (carnivoro == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } else if (carnivoro == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                } else if (tipo == "anelideo")
                {
                    if (carnivoro == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    } else if (carnivoro == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }




        }
    }
}

