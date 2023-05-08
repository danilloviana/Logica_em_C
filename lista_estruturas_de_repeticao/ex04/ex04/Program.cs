
using System;

class Program
/*Construa um programa que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período de 30 dias (ele trabalhou todos os 30 dias) e apresente o salário bruto recebido por ele nesse período, sabendo que o valor do salário é R$ 10,00/hora trabalhada.*/

{
    static void Main(string[] args)
    {
        const double valorHora = 10.00;
        double horasTrabalhadasTotal = 0;

        for (int i = 1; i <= 30; i++)
        {
            Console.Write($"Digite o número de horas trabalhadas no dia {i}: ");
            double horasTrabalhadasDiarias = double.Parse(Console.ReadLine());
            horasTrabalhadasTotal += horasTrabalhadasDiarias;
        }

        double salarioBruto = horasTrabalhadasTotal * valorHora;

        Console.WriteLine($"O salário bruto recebido pelo funcionário nos últimos 30 dias é: R$ {salarioBruto:F2}");
    }
}
