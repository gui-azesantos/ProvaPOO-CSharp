using System;

namespace ProvaPOO.Parte2
{
	class Program
	{
		static void Main(string[] args)
		{
			Gerente A = new Gerente("Jessica", 35, 20000.00);
			A.bonificacao();

			Supervisor B = new Supervisor("Paulo", 30, 10000.00);
			B.bonificacao();

			Vendedor C = new Vendedor("Leandro", 21, 3000.00);
			C.bonificacao();


			Console.WriteLine(" \n Nome: " + A.Nome + " \n Salário: " + A.Salario + " \n Salário com Bonificação " + A.bonificacao());
			Console.WriteLine(" \n Nome: " + B.Nome + " \n Salário: " + B.Salario + " \n Salário com Bonificação " + B.bonificacao());
			Console.WriteLine(" \n Nome: " + C.Nome + " \n Salário: " + C.Salario + " \n Salário com Bonificação " + C.bonificacao());



		}
	}
}
