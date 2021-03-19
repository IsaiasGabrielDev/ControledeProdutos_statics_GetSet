using System;
using System.Globalization;

namespace ControledeProdutos_Contrutores
{
    class Program
    {
        static void Main(string[] args) //Utilizando Sobrecarga em construtores de objetos.
        {
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto p = new Produto(nome, preco); //ele aceita tanto os 3 parametros como apenas 2.

            /* // Syntasse alternativa, independente de não haver construtores.
             Produto p = new Produto 
            {   
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

             */

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
