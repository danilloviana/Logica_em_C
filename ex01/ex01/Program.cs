/*Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário não exiba mensagem nenhuma.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da conta de luz: ");
        double valorContaLuz = double.Parse(Console.ReadLine());

        if (valorContaLuz > 50.00)
        {
            Console.WriteLine("Você está gastando muito.");
        }
    }
}
