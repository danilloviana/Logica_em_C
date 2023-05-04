/*Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) de uma sala, sendo que os comprimentos das paredes (L e C) são fornecidos pelo usuário. Apresente a área depois de calculada.*/
//Algoritmo para calcular a área de uma sala
using System;

namespace CalcularAreaSala
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double L, C, AREA;

            //Leitura dos valores do comprimento das paredes
            Console.WriteLine("Digite o comprimento da parede L: ");
            L = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da parede C: ");
            C = double.Parse(Console.ReadLine());

            //Cálculo da área da sala
            AREA = L * C;

            //Apresentação do resultado
            Console.WriteLine("A área da sala é: " + AREA + " metros quadrados.");
        }
    }
}
