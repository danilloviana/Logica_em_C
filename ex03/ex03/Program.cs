/* Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor monetário do desconto (D), sendo que o preço do produto (PR) é fornecido pelo usuário e o desconto é de 5%. Apresentar o valor do desconto*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double PR, D;
        Console.WriteLine("Digite o preço do produto:");
        PR = double.Parse(Console.ReadLine());
        D = PR * 0.05;
        Console.WriteLine("O valor do desconto é de: " + D.ToString("C"));
    }
}
