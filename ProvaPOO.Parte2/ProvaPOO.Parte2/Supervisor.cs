using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO.Parte2
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public double bonificacao()
        {
            return (this.Salario + 5000.00);
        }
    }
}
