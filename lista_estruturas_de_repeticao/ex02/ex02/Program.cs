
using System;

class Program
/*Construa um programa que leia a quantidade (Q) e o preço (PR) de 45 produtos diferentes, comprados por uma empresa, e apresente o total gasto por ela.*/
{
    static void Main(string[] args)
    {
        int quantidadeTotal = 0;
        double valorTotal = 0;

        for (int i = 1; i <= 45; i++)
        {
            Console.Write($"Digite a quantidade do produto {i}: ");
            int quantidade = int.Parse(Console.ReadLine());
            quantidadeTotal += quantidade;

            Console.Write($"Digite o preço do produto {i}: ");
            double preco = double.Parse(Console.ReadLine());
            valorTotal += quantidade * preco;
        }

        Console.WriteLine($"A empresa gastou um total de R$ {valorTotal.ToString("F2")} na compra de {quantidadeTotal} produtos.");
    }
}
