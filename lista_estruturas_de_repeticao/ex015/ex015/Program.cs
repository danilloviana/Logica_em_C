/*15. Construa um programa que leia um número e indique se ele é par ou impar. O programa só deve levar em consideração valores positivos.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("Número inválido. O valor deve ser positivo.");
        }
        else
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
