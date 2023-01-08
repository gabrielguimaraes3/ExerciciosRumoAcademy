using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios
{
	public class Vendedor
	{
		public void Vendas()

			//Exercicio 01
		{
			Console.WriteLine("Informe o nome do vendedor: ");
			string vendedor = Console.ReadLine();

			Console.WriteLine("Agora informe o salario fixo do(a) " + vendedor + ": ");
			decimal salarioFixo = Convert.ToDecimal(Console.ReadLine());

			if (salarioFixo < 0) return;

			Console.WriteLine("Informe o total de vendas efetuadas por ele no mês (em dinheiro): ");
			decimal vendasMes = Convert.ToDecimal(Console.ReadLine());

			if (vendasMes < 0) return;

			decimal comissaoVendas = vendasMes * 0.15m;

			decimal salarioFinal = salarioFixo + comissaoVendas;

			Console.WriteLine(vendedor + " tem salaro fixo de " + salarioFixo.ToString("C") + " e com as vendas desse mês ele irá receber " 
				+ salarioFinal.ToString("C") + ", sendo que " + comissaoVendas.ToString("C") + " se refere a comissão de suas vendas!");
		}
	}
}
