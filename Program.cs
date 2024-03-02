using System;

namespace PedidosProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual produto você deseja? ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorTotal = CalcularValorTotal(nomeProduto, precoProduto, quantidade);

            Console.WriteLine($"O valor total do Produto {nomeProduto} é: R${valorTotal}");

        }
        static double CalcularValorTotal(string nomeProduto, double precoProduto, int quantidade)
        {
            double valorTotal = 0;

            if (quantidade <= 10)
            {
                valorTotal = precoProduto * quantidade;
            }
            else if (quantidade <= 20)
            {
                valorTotal = precoProduto * quantidade * 0.9;
            }
            else if (quantidade <= 50)
            {
                valorTotal = precoProduto * quantidade * 0.8;
            }
            else
            {
                valorTotal = precoProduto * quantidade * 0.75;
            }
            return valorTotal;
        }
    }
}
