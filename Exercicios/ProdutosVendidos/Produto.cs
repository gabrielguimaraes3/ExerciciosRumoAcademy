using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios.ProdutosVendidos
{
    public class Produto
    {
        public string nome { get; set; }
        public double precoCompra { get; set; }
        public double precoVenda { get; set; }
        public int quantidadeVendida { get; set; }
        public double lucroProduto { get; set; }
        public string produtoFinal { get; set; }
    }
}
