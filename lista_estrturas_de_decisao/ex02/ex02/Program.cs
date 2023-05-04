using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // 2. Maior entre dois números: Ler dois números inteiros, quaisquer e mostrar na tela uma mensagem indicando qual é o maior, ou se são iguais.
        int n1;
        int n2;

        Console.WriteLine("Insira o primeiro número:");
        n1 = (int)readValue();
        Console.WriteLine("Insira o segundo número:");
        n2 = (int)readValue();
        if (n1 == n2)
        {
            Console.WriteLine("Os dois números são iguais");
        }
        else
        {
            if (n1 > n2)
            {
                Console.WriteLine(n1.ToString() + " É maior que " + n2);
            }
            else
            {
                Console.WriteLine(n2.ToString() + " É maior que " + n1);
            }
        }
    }

    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
