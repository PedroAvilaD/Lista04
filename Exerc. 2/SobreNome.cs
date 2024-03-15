using System;

namespace SobreNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobreNome;
            char ori; 
            double time; 

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobreNome = Console.ReadLine();
            Console.WriteLine("\nDigite 'm' - Masculino // 'f' - Feminino");
            ori = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nDigite as horas: ");
            time = Convert.ToDouble(Console.ReadLine());

            if(ori == 'f')
            {
                if(time >= 6)
                {
                    Console.WriteLine($"Bom dia Sra. {nome} {sobreNome}");
                }
                else if(time >= 12)
                {
                    Console.WriteLine($"Boa Tarde Sra. {nome} {sobreNome}");
                }
                else if(time >= 18)
                {
                    Console.WriteLine($"Boa Noite Sra. {nome} {sobreNome}");
                }
            }

            if(ori == 'm')
            {
                if (time >= 6 && time < 12)
                {
                    Console.WriteLine($"Bom dia Sr. {nome} {sobreNome}");
                }
                else if (time >= 12 && time < 18)
                {
                    Console.WriteLine($"Boa Tarde Sr. {nome} {sobreNome}");
                }
                else if (time >= 18 || time<6)
                {
                    Console.WriteLine($"Boa Noite Sr. {nome} {sobreNome}");
                }
            }
        }
    }
}