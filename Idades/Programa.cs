using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Programa
{
    class Programa
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            // Primeira Pessoa

            Console.WriteLine("Dados da Primeira pessoa: ");

            string nome1;
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();

            int idade1;
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Segunda Pessoa

            Console.WriteLine("Dados da Segunda pessoa: ");

            string nome2;
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();

            int idade2;
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            double media;
            media = (double) (idade1 + idade2) / 2;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de " + media.ToString("F1", CI) + " anos");


        }
    }
}