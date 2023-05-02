
using System;

class Program
{
    static void Main(string[] args)
    {

        double preco, precof, desc;

        Console.Write("Digite o preço original do produto: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Digite o preço com desconto do produto: ");
        precof = double.Parse(Console.ReadLine());

        desc = (1 - (precof / preco)) * 100;

        Console.WriteLine("O desconto dado foi de " + desc.ToString("F2") + "%.");
    }
}