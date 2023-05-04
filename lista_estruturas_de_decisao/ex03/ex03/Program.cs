using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // 3. Maior entre três números: Ler três números diferentes e mostrar na tela uma mensagem indicando qual é o maior.
        int n1, n2, n3;

        Console.WriteLine("Insira o primeiro número");
        n1 = (int)readValue();
        Console.WriteLine("Insira o segundo número");
        n2 = (int)readValue();
        Console.WriteLine("Insira o terceiro número");
        n3 = (int)readValue();
        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine(n1.ToString() + " É o maior número");
        }
        else
        {
            if (n2 > n3)
            {
                Console.WriteLine(n2.ToString() + " É o maior número");
            }
            else
            {
                Console.WriteLine(n3.ToString() + " É o maior número");
            }
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
