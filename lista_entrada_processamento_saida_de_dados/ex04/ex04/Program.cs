using System;

class Program
{
    static void Main(string[] args)
    {
        double preco, desconto, valorFinal;

        Console.WriteLine("Digite o preço do produto:");
        preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o desconto em %:");
        desconto = double.Parse(Console.ReadLine());

        valorFinal = preco - (preco * desconto / 100);

        Console.WriteLine($"O valor final do produto é R$ {valorFinal:F2}");
    }
}

