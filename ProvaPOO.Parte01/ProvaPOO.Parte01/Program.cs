using System;
using System.Collections;
using System.Collections.Generic;

namespace ProvaPOO.Parte01
{
    class Program
    {
        static void Main(string[] args)
        {

            int maisvelha = 0;
            int posicao = 0;
            int num = 0;

            Pessoa P1 = new Pessoa("João", 15);
            Pessoa P2 = new Pessoa("Leandro", 21);
            Pessoa P3 = new Pessoa("Paulo", 17);
            Pessoa P4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoa = new List<Pessoa>
            {
                P1,
                P2,
                P3,
                P4
            };

            for (int i = 0; i < pessoa.Count; i++)
            {
                if (pessoa[i].idade > maisvelha)
                {

                    maisvelha = pessoa[i].idade;
                    posicao = i;
                }
                Console.WriteLine("Nome: " + pessoa[i].nome + " Idade: " + pessoa[i].idade);
            }
            Console.WriteLine("A pessoa mais velha é: " + pessoa[posicao].nome);
            Console.WriteLine(
                    "--------------------------------------------------------------------------------------------------------------");


            for (int j = 0; j < pessoa.Count; j++)
            {
                if ( pessoa[j].idade < 18)
                {
                    pessoa.RemoveAt(j);
                }
                Console.WriteLine("Nome: " + pessoa[j].nome + " Idade: " + pessoa[j].idade);
                   }
            Console.WriteLine("Quantidade de pessoas : " + pessoa.Count);
            Console.WriteLine(
                    "--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Consulte a lista, entre com o valor a ser consultado: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num > pessoa.Count)
            {
                Console.WriteLine("Valor não disponível");
            }
            else
            {
                Console.WriteLine("Nome: " + pessoa[num].nome + ", " + pessoa[num].idade);
            }

        }
    }
}
