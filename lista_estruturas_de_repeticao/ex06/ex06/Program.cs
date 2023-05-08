/*Construa um programa que apresente o valor de H, sendo H calculado por:
H = 1 + 2 + 3 + 4 + ... + N
O valor de N será apresentado pelo usuário.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor inteiro para N: ");
        int n = int.Parse(Console.ReadLine());

        int h = 0;
        for (int i = 1; i <= n; i++)
        {
            h += i;
        }

        Console.WriteLine($"O valor de H é: {h}");
    }
}
