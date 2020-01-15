using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO.Parte2
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario )
        {
        }

        public double bonificacao()
        {
            return (this.Salario + 3000.00);
        }
    }
}
