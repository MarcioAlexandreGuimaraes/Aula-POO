using System;

class Program
{
    static void Main()
    {
        double horasTrabalhadas, salarioHora, salarioTotal;
        const int horasSemana = 40;
        const int semanasNoMes = 4;

        Console.Write("Digite o número de horas trabalhadas no mês: ");
        horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do salário por hora: ");
        salarioHora = Convert.ToDouble(Console.ReadLine());

        double horasNormais = horasSemana * semanasNoMes;
        if (horasTrabalhadas > horasNormais)
        {
            double horasExtras = horasTrabalhadas - horasNormais;
            double valorHoraExtra = salarioHora * 1.5;
            salarioTotal = (horasNormais * salarioHora) + (horasExtras * valorHoraExtra);
        }
        else
        {
            salarioTotal = horasTrabalhadas * salarioHora;
        }

        Console.WriteLine("O salário total do funcionário é: R$ " + salarioTotal.ToString("F2"));
    }
}
