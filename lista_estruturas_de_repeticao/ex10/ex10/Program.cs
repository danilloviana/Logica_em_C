/*Construa um programa que leia a quantidade (Q) e o preço (PR) de vários produtos diferentes, comprados por uma empresa, e apresente o total gasto por ela. O final da lista de produtos deverá ser indicado pelo usuário (escolha a maneira que preferir).*/

using System;
class Program
{
    static void Main(string[] args)
    {
        double totalGasto = 0;

        while (true)
        {
            Console.Write("Digite a quantidade do produto (ou -1 para sair): ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade == -1)
            {
                break;
            }

            Console.Write("Digite o preço unitário do produto: ");
            double preco = double.Parse(Console.ReadLine());

            if (quantidade < 0 || preco < 0)
            {
                Console.WriteLine("Quantidade e preço não podem ser negativos.");
            }
            else
            {
                double totalProduto = quantidade * preco;
                totalGasto += totalProduto;
            }
        }

        Console.WriteLine("Total gasto pela empresa: R$ " + totalGasto);
    }
}
