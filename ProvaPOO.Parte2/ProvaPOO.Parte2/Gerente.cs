using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO.Parte2
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public double bonificacao()
        {
            return (this.Salario + 10000.00);
        }
    }
}
