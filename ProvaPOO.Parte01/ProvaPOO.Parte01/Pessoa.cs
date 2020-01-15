using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO.Parte01
{
    class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        List<Pessoa> pessoa;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;

        }
    }
}
