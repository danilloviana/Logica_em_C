/*Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) e o perímetro (P) de uma sala, sendo que os comprimentos (L e C) são fornecidos pelo usuário. Apresente a área e o perímetro depois de calculados.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double L, C, AREA, P;

        Console.Write("Digite o comprimento da parede L: ");
        L = double.Parse(Console.ReadLine());

        Console.Write("Digite o comprimento da parede C: ");
        C = double.Parse(Console.ReadLine());

        AREA = L * C;
        P = 2 * (L + C);

        Console.WriteLine("Área da sala: " + AREA);
        Console.WriteLine("Perímetro da sala: " + P);

        Console.ReadLine();
    }
}
