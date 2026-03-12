using POO;
using System;
using System.Collections.Generic;

namespace POO
    {
    class Menu
        {
        Funcionario funcionario;
        public void Cadastro(Repository lista)
            {
            Mensagem("ID:");
            int id = int.Parse(Console.ReadLine());
            Mensagem("Nome: ");
            string nome = Console.ReadLine();
            Mensagem("Salario: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            funcionario = new Funcionario(id, nome, salario);
            lista.Adicionar(funcionario);
            Mensagem("Adicionado com sucesso");
            }
        public void MostarFuncionario(Repository lista)
            {
            foreach (Funcionario funcionario in lista.ListaFuncionarios())
                {
                Mensagem($"ID: {funcionario.id}, Nome: {funcionario.nome} |R${funcionario.salario}\n");
                }
            }
        public void AumentoSalario(Repository lista)
            {
            Mensagem("Qual seria o ID: ");
            int id = int.Parse(Console.ReadLine());
            Mensagem("Qual seria a porcentagem: ");
            decimal porcentagem = decimal.Parse(Console.ReadLine());
            lista.AumentoSalario(id, porcentagem);
            Mensagem("Atualizado com sucesso");
            }
        public void RemocaoFuncionario(Repository lista)
            {
            Mensagem("Qual seria o ID: ");
            int id = int.Parse(Console.ReadLine());
            lista.Remover(id);
            Mensagem("Removido com sucesso");
            }
        static void Mensagem(string mensagem)
            {
            Console.Write(mensagem);
            }
        }
    }

