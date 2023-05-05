using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, perimetro;
        double area, sp;

        Console.WriteLine("Digite o lado A");
        a = (int)readValue();
        Console.WriteLine("Digite o lado B");
        b = (int)readValue();
        Console.WriteLine("Digite o lado C");
        c = (int)readValue();
        if (a < b + c && c < a + b && b < a + c)
        {
            Console.WriteLine("Representam um triângulo");
            perimetro = a + b + c;
            sp = (double)perimetro / 2;
            area = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            Console.WriteLine("  Área= " + area + "  Perímetro= " + perimetro + "  Sp= " + sp);
            if (a == b && a == c)
            {
                Console.WriteLine("Triangulo equilátero");
            }
            else
            {
                if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Triangulo isóseles");
                }
                else
                {
                    Console.WriteLine("Triangulo escaleno");
                }
            }
        }
        else
        {
            Console.WriteLine("Não representam um triângulo");
        }
    }

    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
