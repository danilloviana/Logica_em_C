/*2 – Faça um algoritmo que receba 10 números, calcule e mostre a quantidade de números entre 30 e 90.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int countNumerosEntre30e90 = 0;

        // Entrada de dados
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] >= 30 && numeros[i] <= 90)
            {
                countNumerosEntre30e90++;
            }
        }

 
        Console.WriteLine("Quantidade de números entre 30 e 90: {0}", countNumerosEntre30e90);
    }
}
