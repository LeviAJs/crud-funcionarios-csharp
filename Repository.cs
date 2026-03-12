using System;
using System.Collections.Generic;
using POO;

namespace POO
    {
    class Repository
        {
        private List<Funcionario> listaFuncionario {get; set;}

        public Repository()
            {
            listaFuncionario = new List<Funcionario>();
            }

        public void Adicionar(Funcionario funcionario)
            {
            listaFuncionario.Add(funcionario);
            }
        public void AumentoSalario(int id, decimal aumento)
            {
            foreach (Funcionario funcionario in listaFuncionario)
                {
                if (funcionario.id == id)
                    {
                    funcionario.AumentarSalarioPorPercentual(aumento);
                    }
                }
            }
        public void Remover(int id)
            {
            for (int i = 0; i < listaFuncionario.Count; i++)
                {
                if (listaFuncionario[i].id == id)
                    {
                    listaFuncionario.Remove(listaFuncionario[i]);
                    break;
                    }
                }
            }
        public IReadOnlyList<Funcionario> ListaFuncionarios()
            {
            return listaFuncionario;
            }
        }
    }
