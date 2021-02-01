using System;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0;
            double b = 0;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            double media = (a * 3.5 + b * 7.5) / 11;

            Console.WriteLine("MEDIA = {0:0.00000}", media);
        }
    }
}