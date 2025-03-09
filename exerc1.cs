using System;

class Program
{
    static void Main()
    {
        double vendaMediaMensal, precoAtual, novoPreco;

        Console.Write("Digite a venda média mensal: ");
        vendaMediaMensal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço atual: ");
        precoAtual = Convert.ToDouble(Console.ReadLine());

        if (vendaMediaMensal < 500 && precoAtual < 30)
        {
            novoPreco = precoAtual * 1.10;
            Console.WriteLine("Novo preço: " + novoPreco.ToString("F2"));
        }
        else if (vendaMediaMensal >= 500 && precoAtual >= 30)
        {
            novoPreco = precoAtual * 0.80;
            Console.WriteLine("Novo preço: R$ " + novoPreco.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Não há alteração no preço.");
        }
    }
}

          
