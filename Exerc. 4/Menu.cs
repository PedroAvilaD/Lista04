using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, conta;
            int escolha;
            string stop;

            do
            {
                Console.WriteLine("Digite o valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de c: ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n//////////////////////////////");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - Area do Triangulo");
                Console.WriteLine("2 - Area do Circulo de Raio C");
                Console.WriteLine("3 - Area do Trapezio");
                Console.WriteLine("4 - Area do Quadrado");
                Console.WriteLine("5 - Area do Retangulo");
                Console.WriteLine("\nDigite uma das opcoes do Menu: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        conta = (a * c) / 2;
                        Console.WriteLine($"\nArea do Triangulo = {conta.ToString("F2")}");
                        break;

                    case 2:
                        const double pi = 3.14159;
                        conta = (c * c) * pi;
                        Console.WriteLine($"\nArea do Circulo de Raio C = {conta.ToString("F2")}");
                        break;

                    case 3:
                        conta = ((a + b) * c) / 2;
                        Console.WriteLine($"\nArea do Trapezio = {conta.ToString("F2")}");
                        break;

                    case 4:
                        conta = b * b;
                        Console.WriteLine($"\nArea do Quadrado = {conta.ToString("F2")}");
                        break;

                    case 5:
                        conta = a * b;
                        Console.WriteLine($"\nArea do Retangulo = {conta.ToString("F2")}");
                        break;
                }
                Console.WriteLine("\nDeseja continuar, digite qualquer tecla para continuar ou 'n' para parar ");
                stop = Console.ReadLine();

            } while (stop != "n");
            
        }
    }
}