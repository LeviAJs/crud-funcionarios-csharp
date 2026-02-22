using POO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;


namespace POO

    {
    class programa {
        static void Main(string[] args) {
            var lista = new Repository();//instancia para armazernar dados 
            int escolhaMenu = 0,id, aumento ;
            bool validacao;
            decimal salario;
            while(true) { // inicio do loop
                Console.WriteLine("   Cadastro de usuario");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Mostar usuario");
                Console.WriteLine("3 - Aumentar salario");
                Console.WriteLine("4 - Remover usuario");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");
                validacao = int.TryParse(Console.ReadLine(), out escolhaMenu);
                if (validacao) {
                    
                        switch(escolhaMenu) {
                            case 1:
                                Console.WriteLine("Cadastro "); // cadastro de usuario
                                Console.Write("Id: ");
                                while(!int.TryParse(Console.ReadLine(), out id)) {
                                    Console.WriteLine("Digite um número válido:");
                                    }
                                Console.Write("Entre com o nome: ");
                                string nome = Console.ReadLine();
                                Console.Write("Salario: ");
                                while(!decimal.TryParse(Console.ReadLine(), out salario)) {
                                    Console.WriteLine("Digite um número válido:");
                                    }
                                lista.Adicionar(new Funcionario(id, nome, salario));
                                break;
                            case 2:
                                Console.WriteLine("Lista:"); // mostra de funcionarios
                                lista.Mostar();
                                break;
                            case 3:
                                Console.Write("ID do funcionario: ");// atualização do salario com o aumento
                                while(!int.TryParse(Console.ReadLine(), out id)) {
                                    Console.WriteLine("Digite um número válido:");
                                    }
                                Console.Write("Qual seria o aumento do salario(porcentual): ");
                                while(!int.TryParse(Console.ReadLine(), out aumento)) {
                                    Console.WriteLine("Digite um número válido:");
                                    }
                                lista.Aumento(id,aumento);
                                Console.WriteLine("Aumento realizado com sucesso");
                                break;

                            case 4:
                                Console.WriteLine("ID do usuario: ");// exclusao de usuario 
                                id = int.Parse(Console.ReadLine());
                                lista.Remover(id);
                                Console.WriteLine("Removido com sucesso");
                                break;
                            default:
                                // numero não cadastrado 
                                Console.WriteLine("Numero fora fora da origem digite novamente");
                                validacao = int.TryParse(Console.ReadLine(), out escolhaMenu);
                                break;
                            }
                        }
                if(!validacao) { // validacao deu erro por não ser numero
                    Console.WriteLine("Precisa ser numero");
                    }
                } 
            }  
        }
    }

