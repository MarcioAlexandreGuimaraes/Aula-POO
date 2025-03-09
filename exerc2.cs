using System;

class Program
{
    static void Main()
    {
        double altura, pesoIdeal;
        string sexo;

        Console.Write("Digite a altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o sexo: ");
        sexo = Console.ReadLine().ToUpper();

        if (sexo == "M")
        {
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine("Peso ideal para homem: " + pesoIdeal.ToString("F2") + " kg");
        }
        else if (sexo == "F")
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine("Peso ideal para mulher: " + pesoIdeal.ToString("F2") + " kg");
        }
        else
        {
            Console.WriteLine("Sexo inválido.");
        }
    }
}
