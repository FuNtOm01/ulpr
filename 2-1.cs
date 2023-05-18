using System;
namespace SquareProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольного параллелепипеда a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольного параллелепипеда b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольного параллелепипеда c: ");
            double c = double.Parse(Console.ReadLine());
            double square = 2 * (a * b + a * c + b * c);
            Console.WriteLine($"Площадь поверхности прямоугольного параллелепипеда равна {square}");
        }
    }
}
