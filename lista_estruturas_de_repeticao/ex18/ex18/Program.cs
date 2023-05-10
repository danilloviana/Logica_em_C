/*18. Construa um programa que apresente a tabuada de um número N. O valor de N será apresentado pelo usuário.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para calcular a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
