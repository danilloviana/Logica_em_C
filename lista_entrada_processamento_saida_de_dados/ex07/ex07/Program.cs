using System;
class Program
{
    static void Main(string[] args)
    {
       
        double raio, volume;
      
        Console.WriteLine("Digite o valor do raio da esfera: ");
        raio = double.Parse(Console.ReadLine());

        volume = 4.0 / 3.0 * 3.14 * raio * raio * raio;

        //Saída de dados
        Console.WriteLine("O volume da esfera é: " + volume + " unidades cúbicas.");

    }
}