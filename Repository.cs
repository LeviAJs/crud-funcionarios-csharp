using System;   
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;


namespace POO_treino
    {
    class Repositorio
        {

        private List<Funcionario> listaFuncionario = new List<Funcionario>();
       
        public void Adicionar(Funcionario funcionario) {
            listaFuncionario.Add(funcionario);
            
            }

        public void Aumento(int id, float valor) {
            foreach(Funcionario funcionario in listaFuncionario) {
                if(funcionario.id == id) {
                    funcionario.Receber(valor);
                    Console.WriteLine("Aumento realizado com sucesso");
                    }
                }
            }

        public void Remover(int id) {
            for(int i = 0; i < listaFuncionario.Count; i++) {
                if(listaFuncionario[i].id == id) {
                    listaFuncionario.Remove(listaFuncionario[i]);
                    Console.WriteLine("Removido com sucesso");
                    }
                }
            }
            
        public void Mostar() {
            foreach(Funcionario funcionario in listaFuncionario) {
                
                    Console.Write("ID: " + funcionario.id + ", ");
                    Console.Write("Funcionario: " + funcionario.nome + ", ");
                    Console.WriteLine("Salario: " + funcionario.salario);
                    Console.WriteLine();
                    
                }
            }
        }
    }
