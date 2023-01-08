using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios
{
    public class NumerosPositivos
    {
        public void Positivos()
        {
            //Exercicio 03

            int contador = 0;
            string numerosPositivos = "";
            do
            {
                Console.WriteLine("Digite um número: ");
                double numero = Convert.ToDouble(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("\n" + numero);
                    numerosPositivos = numerosPositivos + Convert.ToString("\n" + numero);
                }
                contador++;
            }
            while(contador <= 15);

            Console.WriteLine(numerosPositivos);
        }
    }
}
