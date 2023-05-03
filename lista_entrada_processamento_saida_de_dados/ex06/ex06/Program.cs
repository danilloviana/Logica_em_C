using System;

class Program
{
    public static void Main(string[] args)
    {
        int anoAtual, anoNascimento, idade;

        Console.WriteLine("Digite o ano atual: ");
        anoAtual = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano de nascimento: ");
        anoNascimento = int.Parse(Console.ReadLine());


        idade = anoAtual - anoNascimento;


        Console.WriteLine("A idade da pessoa é: " + idade + " anos.");
    }
}