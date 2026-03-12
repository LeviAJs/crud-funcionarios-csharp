using System;
using POO;

namespace POO
    {
    class Funcionario
        {

        private int Id
            {
            get; set;
            }
        public int id => Id;
        private string Name
            {
            get; set;
            }
        public string nome => Name;
        private decimal Salary
            {
            get; set;
            }
        public decimal salario => Salary;

        public Funcionario()
            {
            }
        public Funcionario(int id, string name, decimal salary)
            {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            }
        public decimal AumentarSalarioPorPercentual(decimal salario)
            {
            if (salario > 0)
                {
                Salary += Salary * (salario / 100);
                }
            return Salary;
            }
        }
    }



