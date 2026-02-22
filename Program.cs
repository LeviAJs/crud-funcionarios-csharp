using POO_treino;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;


namespace POO

    {
    class programa {
        static void Main(string[] args) {
            //instancia para armazernar dados 
            var lista = new Repositorio();
            
            int escolhaMenu = 0 ;
            bool validacao;
            
            while(true) {

                Console.WriteLine("   Cadastro de usuario");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Mostar usuario");
                Console.WriteLine("3 - Aumentar salario");
                Console.WriteLine("4 - Remover usuario");
                Console.WriteLine("5 - Sair");

                validacao = int.TryParse(Console.ReadLine(), out escolhaMenu);
                if (validacao) {

                    if(validacao) {
                        switch(escolhaMenu) {
                            case 1:
                                Console.WriteLine("Cadastro ");
                                Console.Write("Id: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Entre com o nome: ");
                                string nome = Console.ReadLine();
                                Console.Write("Salario: ");
                                float salario = float.Parse(Console.ReadLine());
                                lista.Adicionar(new Funcionario(id, nome, salario));
                                break;

                            case 2:
                                Console.WriteLine("Lista:");
                                lista.Mostar();
                                break;

                            case 3:
                                Console.Write("ID do funcionario: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Qual seria o aumento do salario: ");
                                float valor = float.Parse(Console.ReadLine());
                                lista.Aumento(id, valor);
                                break;

                            case 4:
                                Console.WriteLine("ID do usuario: ");
                                id = int.Parse(Console.ReadLine());
                                lista.Remover(id);


                                break;
                            default:
                                Console.WriteLine("Numero fora fora da origem digite novamente");
                                validacao = int.TryParse(Console.ReadLine(), out escolhaMenu);
                                break;
                            }
                        }
                    else {
                        Console.WriteLine("Precisa ser numero");
                        }
                    }
                }
                
            }  
        }
    }

