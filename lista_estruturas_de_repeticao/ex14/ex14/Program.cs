/*14. Construa um programa que leia vários números inteiros e mostre qual foi o maior e o menor valor fornecido. Para cada valor digitado, deve ser solicitado ao usuário que ele digite se ele deseja continuar entrando com valores.
OBS: Não se esqueça de validar a resposta do usuário, pois ele só pode responder “S” ou “N”.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int maior = int.MinValue;
        int menor = int.MaxValue;
        string resposta = "S";

        while (resposta == "S" || resposta == "s")
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }

            Console.Write("Deseja continuar digitando números? (S/N): ");
            resposta = Console.ReadLine();

            while (resposta != "S" && resposta != "s" && resposta != "N" && resposta != "n")
            {
                Console.Write("Resposta inválida. Digite 'S' para continuar ou 'N' para sair: ");
                resposta = Console.ReadLine();
            }
        }

        Console.WriteLine($"O maior número digitado foi: {maior}");
        Console.WriteLine($"O menor número digitado foi: {menor}");
    }
}
