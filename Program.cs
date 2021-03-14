using System;

namespace Exercicio_GRITADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string textomodificado;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escreva Qualquer coisa, Sera automaticamente trocado por letras maiusculas:");
            Console.ResetColor();

            textomodificado= Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{textomodificado.ToUpper()}");
        }   
    }
}