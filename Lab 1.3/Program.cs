using System;

namespace Lab_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float a = 10;
            const float b = 0.01F;

            const double x = 10;
            const double y = 0.01;

            const decimal i = 10;
            const decimal j = 0.01M;

            float numeratorFloat = (float)(Math.Pow(a + b, 4) - (Math.Pow(a ,4) + 4 * Math.Pow(a, 3) * b));
            float denominatorFloat = (float)(6 * Math.Pow(a, 2) * Math.Pow(b, 2) + 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4));

            double numeratorDouble = Math.Pow(x + y, 4) - (Math.Pow(x, 4) + 4 * Math.Pow(x, 3) * y);
            double denominatorDouble = 6 * Math.Pow(x, 2) * Math.Pow(y, 2) + 4 * x * Math.Pow(y, 3) + Math.Pow(y, 4);

            decimal numeratorDecimal = (i + j) * (i + j) * (i + j) * (i + j) - (i * i * i * i + 4 * i * i * i * j);
            decimal denominatorDecimal = 6 * i * i * j * j + 4 * i * j * j * j + j * j * j * j;

            Console.WriteLine($"Значение выражения (float): {numeratorFloat / denominatorFloat}");
            Console.WriteLine($"Значение выражения (double): {numeratorDouble / denominatorDouble}");
            Console.WriteLine($"Значение выражения (decimal): {numeratorDecimal / denominatorDecimal}");

            Console.ReadLine();
        }
    }
}
