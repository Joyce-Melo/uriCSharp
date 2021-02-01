using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = 3.14159;
            double raio = 0;

        
            raio = double.Parse(Console.ReadLine());

            double area = n * raio * raio;

        Console.WriteLine("A = {0:0.0000}", area);
        }
    }
}