using System;

class Program
{
    static void Main(string[] args)
    {
        double pesoTotal = 0;

        for (int i = 1; i <= 25; i++)
        {
            Console.Write($"Digite o peso da caixa {i}: ");
            double pesoCaixa = double.Parse(Console.ReadLine());
            pesoTotal += pesoCaixa;
        }

        Console.WriteLine($"O peso total carregado pelo caminhão é {pesoTotal} kg.");
    }
}
