using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números (entre 3 e 10):");
        int quantidade = LerQuantidadeNumeros();

        double[] numeros = new double[quantidade];
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o número {i + 1}:");
            numeros[i] = LerNumero();
        }

        double soma = CalcularSoma(numeros);
        double media = CalcularMedia(numeros);

        Console.WriteLine($"A soma dos números é: {soma}");
        Console.WriteLine($"A média dos números é: {media}");
    }

    static int LerQuantidadeNumeros()
    {
        int quantidade;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 3 && quantidade <= 10)
            {
                return quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Digite um número entre 3 e 10.");
            }
        }
    }

    static double LerNumero()
    {
        double numero;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Número inválido. Digite um valor numérico válido.");
            }
        }
    }

    static double CalcularSoma(double[] numeros)
    {
        return numeros.Sum();
    }

    static double CalcularMedia(double[] numeros)
    {
        return numeros.Average();
    }
}

