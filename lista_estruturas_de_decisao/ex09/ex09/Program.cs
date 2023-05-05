using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double nota1, nota10, nota100, troco, pagamento, compra;

        Console.WriteLine("Digite o valor da compra");
        compra = readValue();
        Console.WriteLine("Digite o valor do pagamento");
        pagamento = readValue();
        troco = pagamento - compra;
        if (troco == 0)
        {
            Console.WriteLine(" Não terá troco");
        }
        else
        {
            if (troco == 100)
            {
                nota10 = troco - 10;
                nota1 = troco % 10;
                Console.WriteLine("Notas de 10= " + nota10);
                Console.WriteLine("Notas de 1= " + nota1);
            }
            else
            {
                nota100 = troco / 100;
                nota10 = (double)(troco % 100) / 10;
                nota1 = (double)(troco % 100) / 1;
                Console.WriteLine("Notas de 100= " + nota100);
                Console.WriteLine("Notas de 10= " + nota10);
                Console.WriteLine("Notas de 1= " + nota1);
            }
        }
    }

    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
