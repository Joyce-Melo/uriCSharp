using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 0;
            int valor2 = 0;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            int prod = valor1 * valor2;

            Console.WriteLine("PROD = " + prod);
        }
    }
}