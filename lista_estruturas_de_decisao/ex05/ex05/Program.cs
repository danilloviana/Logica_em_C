using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // 5. Equação do segundo grau - Ler os coeficientes a, b e c de uma equação de segundo grau e, antes de calcular as raízes, calcular o valor de delta. Se este for negativo, informar que a equação não tem solução real. Se for zero, mostrar a única raiz. Se positivo, mostra as duas raízes.
        double a;
        double b;
        double c;
        double delta;
        double x1;
        double x2;

        Console.WriteLine("Digite o valor de a:");
        a = readValue();
        Console.WriteLine("Digite o valor de b:");
        b = readValue();
        Console.WriteLine("Digite o valor de c:");
        c = readValue();
        delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("A equação não tem solução real");
        }
        else
        {
            if (delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
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
