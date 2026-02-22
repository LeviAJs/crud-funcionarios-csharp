using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System;



namespace POO_treino
    {
    class Funcionario
        {
        private int Id { get; set; }
        public int id => Id;
        private string Name {get; set;}
        public string nome => Name;
        private float Salary {get; set;}
        public float salario => Salary;

        public Funcionario(int id, string name, float salary) {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        
            }
        public Funcionario() { }


        public float Receber(float salario) {
            if(salario > 0) {
                Salary += (salario/100);
                }
            return Salary;
            }
        }
    }

