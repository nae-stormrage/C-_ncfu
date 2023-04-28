// p = 1 - ((cos(x) * sin ^ 2(y)) / (1 * 2)) + ((cos ^ 4(x) * sin ^ 3(y) / (3 * 4)) - ((cos ^ 5(x) * sin ^ 6(y) / (4 * 6))

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите количество слагаемых: ");
            int n = int.Parse(Console.ReadLine());

            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    p += Math.Pow(Math.Cos(x), 2 * i) * Math.Pow(Math.Sin(y), 2 * i - 1) / ((2 * i - 1) * (2 * i));
                }
                else
                {
                    p -= Math.Pow(Math.Cos(x), 2 * i) * Math.Pow(Math.Sin(y), 2 * i - 1) / ((2 * i - 1) * (2 * i));
                }
            }

            Console.WriteLine($"Сумма {n} членов последовательности равна {p}");
        }
    }
}