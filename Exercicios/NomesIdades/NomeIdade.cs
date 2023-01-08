using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios._04NomesIdades
{
    public class NomeIdade
    {
        public void MaisVelho()
        {
            //Exercicio 04


            //var pessoas = new Pessoa[3];
            //for (int i = 0; i < pessoas.Length; i++)
            //{
            //    Console.WriteLine("Informe seu nome:");
            //    pessoas[i].Nome = Console.ReadLine();

            //    Console.WriteLine("Informe sua idade:");
            //    pessoas[i].Idade = Convert.ToInt32(Console.ReadLine());

            //}
            //var teste = pessoas.OrderByDescending(x => x.Idade);
            //var teste2 = teste.First().Idade;
            //Console.WriteLine(teste2);



            var pessoas = new List<Pessoa>();


            for (int quantidadePEssoas = 0; quantidadePEssoas < 3; quantidadePEssoas++)
            {
                Pessoa pessoa = new Pessoa();


                Console.WriteLine("Informe seu nome: ");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Agora informe sua idade: ");
                pessoa.Idade = Convert.ToInt32(Console.ReadLine());

                string humano = $"Nome: {pessoa.Nome}  Idade: {pessoa.Idade}";
                Console.WriteLine(humano);

                pessoas.Add(pessoa);
            }

            var teste = pessoas.OrderBy(pessoa => pessoa.Idade).ToList();

            var teste2 = teste.Last().Idade;

            Console.WriteLine(teste2);

        }

    }
}
