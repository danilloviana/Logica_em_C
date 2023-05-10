/*16. Anacleto tem 1,50m e cresce 2 centímetros por ano, enquanto Felisberto tem 1,10 e cresce 3 centímetros por ano. Construa um programa que calcule e apresente quantos anos serão necessários para que Felisberto seja maior que Anacleto.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double alturaAnacleto = 1.50;
        double alturaFelisberto = 1.10;
        int anos = 0;

        while (alturaFelisberto <= alturaAnacleto)
        {
            alturaAnacleto += 0.02; 
            alturaFelisberto += 0.03;
            anos++;
        }

        Console.WriteLine($"Serão necessários {anos} anos para que Felisberto seja maior que Anacleto.");
    }
}
