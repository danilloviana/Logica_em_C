/*1 – Faça um algoritmo que receba a idade e o peso de 7 pessoas, calcule e mostre:
• A quantidade de pessoas com mais de 90 quilos;
• A média das idades das 7 pessoas*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] idades = new int[7];
        double[] pesos = new double[7];
        int countMais90Kg = 0;
        int somaIdades = 0;

        // Entrada de dados
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Digite a idade da pessoa {0}: ", i + 1);
            idades[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da pessoa {0}: ", i + 1);
            pesos[i] = double.Parse(Console.ReadLine());

            if (pesos[i] > 90)
            {
                countMais90Kg++;
            }

            somaIdades += idades[i];
        }

    
        double mediaIdades = somaIdades / 7.0;

        Console.WriteLine("Quantidade de pessoas com mais de 90 quilos: {0}", countMais90Kg);
        Console.WriteLine("Média das idades: {0}", mediaIdades);
    }
}
