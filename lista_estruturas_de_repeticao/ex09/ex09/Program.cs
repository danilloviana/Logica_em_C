/*Construa um programa que leia o conjunto de 20 números inteiros e mostre qual foi o maior e o menor valor fornecido.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int max = int.MinValue; 
        int min = int.MaxValue; 
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > max)
            { 
                max = numero;
            }
            if (numero < min)
            {
                min = numero;
            }
        }
        Console.WriteLine($"O maior número digitado foi {max} e o menor número digitado foi {min}.");
    }
}
