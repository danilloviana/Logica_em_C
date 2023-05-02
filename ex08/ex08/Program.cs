using System;

class Program
{
    static void Main(string[] args)
    {
        int he, me, hs, ms; // horas e minutos de entrada e saída
        double tempoTotal, valor; // tempo de permanência em minutos e valor a ser pago

        Console.Write("Digite a hora de entrada (0-23): ");
        he = int.Parse(Console.ReadLine());
        Console.Write("Digite o minuto de entrada (0-59): ");
        me = int.Parse(Console.ReadLine());
        Console.Write("Digite a hora de saída (0-23): ");
        hs = int.Parse(Console.ReadLine());
        Console.Write("Digite o minuto de saída (0-59): ");
        ms = int.Parse(Console.ReadLine());

        // cálculo do tempo de permanência em minutos
        tempoTotal = ((hs * 60) + ms) - ((he * 60) + me);

        // cálculo do valor a ser pago
        valor = Math.Ceiling(tempoTotal / 60) * 4;

        Console.WriteLine("Tempo de permanência: {0} minutos", tempoTotal);
        Console.WriteLine("Valor a ser pago: R$ {0:F2}", valor);
    }
}
