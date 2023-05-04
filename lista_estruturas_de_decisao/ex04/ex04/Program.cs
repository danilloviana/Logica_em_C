using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // 4. Divisão: Ler dois números e efetuar uma divisão, mas somente se o divisor for diferente de zero; quando isto ocorrer, é mostrada uma mensagem de erro apropriada.
        double n1;
        double n2;
        double razao;

        Console.WriteLine("Digite o primeiro número");
        n1 = readValue();
        Console.WriteLine("Digite o segundo número");
        n2 = readValue();
        if (n1 > 0 && n2 > 0)
        {
            razao = n1 / n2;
            Console.WriteLine("O Resultado da divisão é " + razao);
        }
        else
        {
            Console.WriteLine("Esta operação não pode ser realizada");
        }
    }


    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
