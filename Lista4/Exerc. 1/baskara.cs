[11:11] PEDRO HENRIQUE AVILA DOMINGOS
using System;

namespace Baskara;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, delta; 
        double x1, x2; 

        Console.WriteLine("Digite o valor de A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de B: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de C: ");
        c = Convert.ToInt32(Console.ReadLine());

        if (a != 0)
        {
            delta = (b * b) - 4 * a * c;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("------------------------------------------");

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Raizes: "); 
                Console.WriteLine("x1 = " + x1.ToString("F2"));
                Console.WriteLine("x2 = " + x2.ToString("F2"));
            }
            if (delta < 0)
            {
                Console.WriteLine("Nao existe Raiz");
            }
            if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Raiz unica: " + x1.ToString("F2"));
            }
        } 
        else if (a == 0)
        {
            Console.WriteLine("Nao e equacao de 2 grau, pois a = 0"); 
        }
    }
}
