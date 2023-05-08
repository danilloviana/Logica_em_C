using System;

class Program
/*Construa um programa que apresente o peso total que será carregado por um caminhão. Sabe-se que esse caminhão carrega 25 caixas, com pesos diferentes. Será entrada do programa o peso (P) de cada uma das caixas.*/
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
