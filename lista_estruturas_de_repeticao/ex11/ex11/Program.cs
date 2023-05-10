/*11. Construa um programa que leia vários números inteiros e positivos, calculando ao final da seqüência a soma e a média desses números. A seqüência termina quando o usuário entrar com um valor negativo (esse valor não deve fazer parte de nenhum dos cálculos).*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int quantidade = 0;

        while (true)
        {
            Console.Write("Digite um número inteiro positivo (ou um número negativo para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            soma += numero;
            quantidade++;
        }

        if (quantidade > 0)
        {
            double media = (double)soma / quantidade;
            Console.WriteLine($"A soma dos números digitados é: {soma}");
            Console.WriteLine($"A média dos números digitados é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi digitado.");
        }
    }
}
