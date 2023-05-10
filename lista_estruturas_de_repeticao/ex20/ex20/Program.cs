/*21.Construa um programa que calcule e apresente o total da compra realizada pelo cliente em uma loja. São fornecidos para o programa, o preço da etiqueta (PE) de cada um dos produtos comprados e, com a compra encerrada, a condição de pagamento escolhida pelo cliente (CP). Utilize para os cálculos a tabela de condições de pagamento a seguir:
Código da condição de pagamento
Condição de pagamento
1
À vista em dinheiro ou cheque, com 10% de desconto
2
À vista com cartão de crédito, com 5% de desconto
3
Em 2 vezes, preço normal de etiqueta sem juros
4
Em 3 vezes, preço de etiqueta com acréscimo de 10%
Uma compra pode ser composta por mais do que um produto, portanto, deve ser indicado para o programa quando a compra deve ser encerrada (escolha a forma que desejar).
OBS: Não esqueça de validar a entrada do código da condição de pagamento.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double totalCompra = 0;

        while (true)
        {
            Console.Write("Digite o preço da etiqueta do produto (ou um valor negativo para encerrar a compra): ");
            double precoEtiqueta = Convert.ToDouble(Console.ReadLine());

            if (precoEtiqueta < 0)
                break;

            Console.Write("Digite o código da condição de pagamento (1 - À vista em dinheiro/cheque, 2 - À vista com cartão de crédito, 3 - Em 2 vezes, 4 - Em 3 vezes): ");
            int codPagamento = Convert.ToInt32(Console.ReadLine());

            while (!IsValidCodPagamento(codPagamento))
            {
                Console.WriteLine("Código de pagamento inválido. Digite novamente.");
                Console.Write("Digite o código da condição de pagamento (1 - À vista em dinheiro/cheque, 2 - À vista com cartão de crédito, 3 - Em 2 vezes, 4 - Em 3 vezes): ");
                codPagamento = Convert.ToInt32(Console.ReadLine());
            }

            double valorPagamento = CalcularValorPagamento(precoEtiqueta, codPagamento);
            totalCompra += valorPagamento;
        }

        Console.WriteLine("Total da compra: R$" + totalCompra.ToString("F2"));
    }

    static bool IsValidCodPagamento(int codPagamento)
    {
        return codPagamento >= 1 && codPagamento <= 4;
    }

    static double CalcularValorPagamento(double precoEtiqueta, int codPagamento)
    {
        double valorPagamento = 0;

        switch (codPagamento)
        {
            case 1:
                valorPagamento = precoEtiqueta * 0.9; // Desconto de 10% à vista em dinheiro/cheque
                break;
            case 2:
                valorPagamento = precoEtiqueta * 0.95; // Desconto de 5% à vista com cartão de crédito
                break;
            case 3:
                valorPagamento = precoEtiqueta; // Preço normal em 2 vezes sem juros
                break;
            case 4:
                valorPagamento = precoEtiqueta * 1.1; // Acréscimo de 10% em 3 vezes
                break;
        }

        return valorPagamento;
    }
}

