using System;

namespace Atividade1
{
    class Program
    {
        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("┌───────────────────────────────────────────────┐\n│            O que deseja realizar?             │\n├───────────────────────────────────────────────┤\n│ digite 1 para inserir 10 nomes                │\n│ digite 2 para listar os nomes atuais na lista │\n│ digite 3 para sair do programal               │\n└───────────────────────────────────────────────┘");
            return Console.ReadLine();
        }
        static string[] Inserir()
        {
            string[] nome = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Qual o nome {i + 1}º nome?  ");
                nome[i] = Console.ReadLine();
            }
            return nome;
        }
        static void Listar(string[] lista)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{lista[i]}");
            }
            Console.ReadKey();
        }
        static void Sair()
        {
            Console.WriteLine("FIM.");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            string[] lista = new string[10];
            string menu = "0";
            while (menu != "3")
            {
                menu = Menu();
                switch (menu)
                {
                    case "1":
                        {
                            lista = Inserir();
                            break;
                        }
                    case "2":
                        {
                            Listar(lista);
                            break;
                        }
                    default:
                        {
                            Sair();
                            break;
                        }
                }
            }
        }
    }
}
