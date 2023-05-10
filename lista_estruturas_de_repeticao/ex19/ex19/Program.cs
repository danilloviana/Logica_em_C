/**/
using System;

class Program
{
    static void Main(string[] args)
    {
        int totalRespostas = 0;
        int somaIdade = 0;
        int[] opinioes = new int[5]; // índices 0-4 representam as opções A-E

        while (true)
        {
            Console.Write("Digite a idade do espectador (ou um número negativo para encerrar a pesquisa): ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 0)
                break;

            Console.Write("Digite a opinião do espectador (A - Ótimo, B - Bom, C - Regular, D - Ruim, E - Péssimo): ");
            char opcao = Console.ReadLine().ToUpper()[0];

            while (!IsValidOpcao(opcao))
            {
                Console.WriteLine("Opção inválida. Digite novamente.");
                Console.Write("Digite a opinião do espectador (A - Ótimo, B - Bom, C - Regular, D - Ruim, E - Péssimo): ");
                opcao = Console.ReadLine().ToUpper()[0];
            }

            totalRespostas++;
            somaIdade += idade;
            opinioes[opcao - 'A']++;
        }

        double mediaIdade = (double)somaIdade / totalRespostas;

        Console.WriteLine("Resultados:");
        Console.WriteLine("Quantidade de pessoas que responderam a pesquisa: " + totalRespostas);
        Console.WriteLine("Média de idade das pessoas que responderam a pesquisa: " + mediaIdade);

        for (int i = 0; i < opinioes.Length; i++)
        {
            double percentual = (double)opinioes[i] / totalRespostas * 100;
            char opcao = (char)('A' + i);
            Console.WriteLine("Porcentagem de respostas " + opcao + ": " + percentual.ToString("F2") + "%");
        }
    }

    static bool IsValidOpcao(char opcao)
    {
        return opcao == 'A' || opcao == 'B' || opcao == 'C' || opcao == 'D' || opcao == 'E';
    }
}
