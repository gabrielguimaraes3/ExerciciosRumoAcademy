using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios
{
    public class Testes
    {
        public void TesteMatriz()
        {
            var matriz = new int [2, 2];
            matriz [0,0] = 1;
            matriz [0, 1] = 45;

            matriz [1,0] = -1;
            matriz[1, 1] = 4;

            matriz.ToString ();
            Console.WriteLine($"{string.Join(", ", matriz)}");
        }
    }
}
