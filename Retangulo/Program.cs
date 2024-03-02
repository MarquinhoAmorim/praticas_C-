using System;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {    

            CultureInfo CI = CultureInfo.InvariantCulture;

            double b, a, area, perimetro, diagonal;

            Console.Write("Base do Retangulo: ");
            b = double.Parse(Console.ReadLine(), CI);

            Console.Write("Altura do Retangulo: ");
            a = double.Parse(Console.ReadLine(), CI);

            area = b * a;
            perimetro = (a*2) + (b*2);
            diagonal = Math.Sqrt((a*a)+(b*b));

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
        }
    }
}