using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            long matri;
            int time;
            double valorSal, salTotal;

            Console.WriteLine("Digite o numero de matricula");
            matri = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Digite o total de horas trabalhadas: ");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: ");
            valorSal = Convert.ToDouble(Console.ReadLine());

            salTotal = time * valorSal;

            Console.WriteLine($"\nMatricula do funcionario: {matri}");
            Console.WriteLine($"Salario Total por hora trabalhada: {salTotal.ToString("F2")}");
        }
    }
}