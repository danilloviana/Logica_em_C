/**/
using System;

class Program
{
    static void Main(string[] args)
    {
        int menor = int.MaxValue;
        string resposta = "S";

        while (resposta == "S" || resposta == "s")
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < menor)
            {
                menor = numero;
            }

            Console.Write("Deseja continuar digitando números? (S/N): ");
            resposta = Console.ReadLine();
        }

        Console.WriteLine($"O menor número digitado foi: {menor}");
    }
}
