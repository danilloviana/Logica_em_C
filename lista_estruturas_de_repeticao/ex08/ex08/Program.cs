class Program
/*Construa um programa que leia o conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido.*/
{
    static void Main(string[] args)
    {
        int max = int.MinValue; 
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > max)
            { 
                max = numero;
            }
        }
        Console.WriteLine($"O maior número digitado foi {max}.");
    }
}