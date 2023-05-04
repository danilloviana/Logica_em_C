using System;

public class ex01
{
    public static void Main(string[] args)
    {
        // 1. Construa um aplicativo que verifique e mostre ao usuário  qual combustível compensa utilizar em um automóvel “flex”. Sabe-se que a relação entre o preço do  álcool e o preço da gasolina é 0,7.
        double alcool;
        double gasolina;
        double razao;

        Console.WriteLine("Digite o preço da gasolina");
        gasolina = readValue();
        Console.WriteLine("Digite o preço do álcool");
        alcool = readValue();
        razao = alcool / gasolina;
        if (razao < 0.7)
        {
            Console.WriteLine("Abasteça álcool");
        }
        else
        {
            Console.WriteLine("Abasteça gasolina!");
        }
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
