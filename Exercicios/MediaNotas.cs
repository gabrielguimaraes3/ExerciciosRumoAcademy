using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios
{
    public class MediaNotas
    {
        public void Notas()
        {
            //Exercicio 02

            double notas = 0;
            Console.WriteLine("quantos notas deseja tirar a media? ");
            int quantidadesNostas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadesNostas; i++)
            {
                Console.WriteLine("informe a nota: ");
                double novaNota = Convert.ToDouble(Console.ReadLine());

                notas = notas + novaNota;

            }

            double mediaNotas = notas / quantidadesNostas;
            Console.WriteLine("a media das notas é: " + mediaNotas);
        } 
    }
}
