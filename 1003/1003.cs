using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}