/*A conversão de graus Fahrenheit para Celsius é obtida pela fórmula C=5/9(F-32). Construa um programa que calcule e apresente TODAS as temperaturas (em Celsius) correspondentes aquelas em Fahrenheit de 1 até 50, ou seja, para cada temperatura em Fahrenheit, variando de 1 até 50, calcular e apresentar uma temperatura em Celsius.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int fahrenheit = 1; fahrenheit <= 50; fahrenheit++)
        {
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            Console.WriteLine($"{fahrenheit} graus Fahrenheit correspondem a {celsius:F2} graus Celsius.");
        }
    }
}
