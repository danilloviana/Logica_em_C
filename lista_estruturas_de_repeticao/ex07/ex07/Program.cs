/*Construa um programa que calcule N! (fatorial de N), sendo que o valor de N (inteiro) é fornecido pelo usuário. Sabe-se que:
N! = 1 x 2 x 3 x 4 x .... x N
OBS: 0! = 1 (fatorial do número zero é igual a 1 por definição).
Além disso, não deve ser permitido que seja calculado o fatorial de número negativo, pois isso não existe.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor inteiro para N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
        }
        else
        {
            int fatorial = 1;
            for (int i = 2; i <= n; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine($"O fatorial de {n} é: {fatorial}");
        }
    }
}
