using System;

namespace ByteBank1
{
    public class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Total armazenado no banco");
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }



        private static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<string> saldos)
        {
            for (int i=0; i<cpfs.Count; i++)
            {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:f2}");
            }
        }

        private static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.WriteLine("Antes de começar a usar, vamos configurar alguns dados!");
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.WriteLine("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> senhas)
        {
            Console.WriteLine("Digite o cpf: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(d => d == cpfParaDeletar);
            cpfs.Remove(cpfParaDeletar);

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possivel deletar essa Conta");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletado com sucesso");
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

            Console.WriteLine("Digite a quantidade de Usuários: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<double> saldos = new List<double>();   
            List<string> senha = new List<string>();


           
            int option;
            
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("---------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;

                    case 2:

                        break;

                    case 3:
                        ListarTodasAsContas(cpfs, titulares);
                        break;
                } 
                
               
               

                Console.WriteLine();
                Console.WriteLine("---------------");
                Console.WriteLine();

            } while (option != 0);

        }

        
    }
}

