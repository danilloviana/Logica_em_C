using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double salario;

        Console.WriteLine("Digite o salário");
        salario = readValue();
        if (salario >= 100)
        {
            if (salario >= 100 && salario < 500)
            {
                salario = salario * 0.10;
                Console.WriteLine("Salário (10%): " + salario);
            }
            else
            {
                if (salario >= 500 && salario < 2000)
                {
                    salario = salario * ((double)18 / 100);
                    Console.WriteLine("Salário (18%): " + salario);
                }
                else
                {
                    salario = salario * ((double)100 / 25);
                    Console.WriteLine("Salário (25%): " + salario);
                }
            }
        }
        else
        {
            Console.WriteLine("Isento");
        }
    }
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
