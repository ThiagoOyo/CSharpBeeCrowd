using System;

namespace FixedPassword_1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            while (true)
            {
                int password = int.Parse(Console.ReadLine());

                if (password != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                } else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }

            }




        }
    }
}

