using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO.Parte2
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public double Salario { get; set; }


        protected Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public double bonificacao()
        {
            return (this.Salario);
        }
    }

}