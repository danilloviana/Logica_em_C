using System;

class Program
{
    static void Main(string[] args)
    {
        double valDolar, cot, valReal;

        Console.Write("Informe a quantidade de dólares guardados no cofre: ");
        valDolar = double.Parse(Console.ReadLine());

        Console.Write("Informe a cotação do dólar naquele dia: ");
        cot = double.Parse(Console.ReadLine());

        valReal = valDolar * cot;

        Console.WriteLine("O valor em reais correspondente é: R$ " + valReal.ToString("F2"));
    }
}
