/*17. Construa um programa que calcule a área total de uma residência (sala, cozinha, quartos, etc., sendo todos eles retangulares). O usuário deverá entrar com a largura (L) e o comprimento (C) de cada cômodo da casa. Em seguida deverá ser apresentada uma pergunta, solicitando a confirmação do usuário para continuar com a entrada de dados (a confirmação será dada quando o usuário entrar com “S”). Caso ele entre com o valor “N”. Deverá ser apresentada a área total da casa.
OBS: Não se esqueça de validar a entrada da resposta do usuário, que só pode aceitar os caracteres “S” ou “N”.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double areaTotal = 0;
        string resposta = "S";

        while (resposta == "S" || resposta == "s")
        {
            Console.Write("Digite a largura do cômodo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do cômodo: ");
            double comprimento = double.Parse(Console.ReadLine());

            double areaCcomodo = largura * comprimento;
            areaTotal += areaCcomodo;

            Console.Write("Deseja continuar adicionando cômodos? (S/N): ");
            resposta = Console.ReadLine();

            while (resposta != "S" && resposta != "s" && resposta != "N" && resposta != "n")
            {
                Console.Write("Resposta inválida. Digite 'S' para continuar ou 'N' para sair: ");
                resposta = Console.ReadLine();
            }
        }

        Console.WriteLine($"A área total da residência é: {areaTotal} m²");
    }
}

