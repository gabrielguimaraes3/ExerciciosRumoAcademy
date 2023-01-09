using ExerciciosDia04_01.Exercicios.ProdutosVendidos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDia04_01.Exercicios
{
    public class LucroProduto
    {

        public void Ites()
        {



            var produtos = new List<Produto>();

            string cadastrarProduto = "";




            while (cadastrarProduto != "N")
            {
                Produto produto = new Produto();


                Console.WriteLine("Informe o produto: ");
                produto.nome = Console.ReadLine();

                Console.WriteLine("Preço de compra deste produto: ");
                produto.precoCompra = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Preço de venda deste produto: ");
                produto.precoVenda = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade vendida deste produto: ");
                produto.quantidadeVendida = Convert.ToInt32(Console.ReadLine());

                produto.lucroProduto = (produto.precoVenda - produto.precoCompra) * produto.quantidadeVendida;

                Console.WriteLine("Gostaria de contiinuar cadastrando produtos? Se sim digite (S), se não digite (N)");
                cadastrarProduto = Console.ReadLine();
                
                produto.produtoFinal = $"\nProduto: {produto.nome} \nPreço de compra: {produto.precoCompra} " +
                   $"\nPreço de venda: {produto.precoVenda} \nQuantidade vendida: {produto.quantidadeVendida}" +
                   $"\nLucro: {produto.lucroProduto}\n";

                produtos.Add(produto);

                
            }


            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.produtoFinal);
            }
            
           
        }


    }


}
