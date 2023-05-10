/*12. Construa um programa que leia vários números inteiros e mostre qual foi o maior valor fornecido. O final da lista de produtos será indicado quando o usuário entrar com um valor negativo (esse valor não deve fazer parte da comparação de valores).*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int maior = int.MinValue;

        while (true)
        {
            Console.Write("Digite um número inteiro (ou um número negativo para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            if (numero > maior)
            {
                maior = numero;
            }
        }

        if (maior != int.MinValue)
        {
            Console.WriteLine($"O maior número digitado foi: {maior}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi digitado.");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int maior = int.MinValue;

        while (true)
        {
            Console.Write("Digite um número inteiro (ou -1 para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            if (numero > maior)
            {
                maior = numero;
            }
        }

        if (maior != int.MinValue)
        {
            Console.WriteLine($"O maior número digitado foi: {maior}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi digitado.");
        }
    }
}
