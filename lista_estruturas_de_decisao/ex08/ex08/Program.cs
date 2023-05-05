using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double xA, yA, xB, yB, xC, yC, dAB, dBC, dAC, per, sp, area;

        Console.WriteLine("Digite entradas B: ");
        Console.WriteLine("Digite XA ");
        xA = readValue();
        Console.WriteLine("Digite YA ");
        yA = readValue();
        Console.WriteLine("Digite entradas B: ");
        Console.WriteLine("Digite XB: ");
        xB = readValue();
        Console.WriteLine("Digite YB: ");
        yB = readValue();
        Console.WriteLine("Digite entradas C: ");
        Console.WriteLine("Digite XC: ");
        xC = readValue();
        Console.WriteLine("Digite YC: ");
        yC = readValue();
        dAB = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yB, 2));
        dAC = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2));
        dBC = Math.Sqrt(Math.Pow(xB - xC, 2) + Math.Pow(yB - yC, 2));
        if (dAB < dBC + dAC && dAC < dAB + dBC && dAB < dAC + dBC)
        {
            Console.WriteLine("TRIÂNGULO");
            per = dAB + dBC + dAC;
            sp = per / 2;
            area = Math.Sqrt(sp * (sp - dAB) * (sp - dBC) * (sp - dAC));
            Console.WriteLine("Perímetro: " + per + (char)13 + "  Área: " + area);
        }
    }

    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
