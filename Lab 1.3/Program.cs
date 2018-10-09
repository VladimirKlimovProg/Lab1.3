using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            float numeratorFloat = (a + b) * (a + b) * (a + b) * (a + b) - (a * a * a * a + 4 * a * a * a * b);
            float denominatorFloat = 6 * a * a * b * b + 4 * a * b * b * b + b * b * b * b;

            double numeratorDouble = (x + y) * (x + y) * (x + y) * (x + y) - (x * x * x * x + 4 * x * x * x * y);
            double denominatorDouble = 6 * x * x * y * y + 4 * x * y * y * y + y * y * y * y;

            decimal numeratorDecimal = (i + j) * (i + j) * (i + j) * (i + j) - (i * i * i * i + 4 * i * i * i * j);
            decimal denominatorDecimal = 6 * i * i * j * j + 4 * i * j * j * j + j * j * j * j;

            Console.WriteLine($"Значение выражения (float): {numeratorFloat / denominatorFloat}");
            Console.WriteLine($"Значение выражения (double): {numeratorDouble / denominatorDouble}");
            Console.WriteLine($"Значение выражения (decimal): {numeratorDecimal / denominatorDecimal}");

            Console.ReadLine();
        }
    }
}
