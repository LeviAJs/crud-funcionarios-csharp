using POO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;


namespace POO

    {
    class programa
        {
        static void Main(string[] args)
            {
            var menu = new Menu();
            var lista = new Repository();
            int EscolhaMenu;
            while (true)
                {
                Console.WriteLine();
                Console.WriteLine("   Cadastro de usuario");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Mostar usuario");
                Console.WriteLine("3 - Aumentar salario");
                Console.WriteLine("4 - Remover usuario");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");

                bool validacao = int.TryParse(Console.ReadLine(), out EscolhaMenu);

                if (validacao)
                    {
                    switch (EscolhaMenu)
                        {
                        case 1:
                            menu.Cadastro(lista);
                            break;
                        case 2:
                            menu.MostarFuncionario(lista);
                            break;
                        case 3:
                            menu.AumentoSalario(lista);
                            break;
                        case 4:
                            menu.RemocaoFuncionario(lista);
                            break;
                        case 5:
                           return;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;
                        }
                    }
                else
                    {
                    Console.WriteLine("Precisa estar em numero padrão");
                    }

                }
            }
        }
    }

