using System;

class Program
/*Construa um programa que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período de 30 dias (ele trabalhou todos os 30 dias) e apresente o total de horas trabalhadas por ele nesse período.*/
{
    static void Main(string[] args)
    {
        double horasTrabalhadasTotal = 0;

        for (int i = 1; i <= 30; i++)
        {
            Console.Write($"Digite o número de horas trabalhadas no dia {i}: ");
            double horasTrabalhadasDiarias = double.Parse(Console.ReadLine());
            horasTrabalhadasTotal += horasTrabalhadasDiarias;
        }

        Console.WriteLine($"O total de horas trabalhadas pelo funcionário nos últimos 30 dias é: {horasTrabalhadasTotal} horas.");
    }
}
