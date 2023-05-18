using System;
namespace ulpr
{
    class program
    {
        static void Main()
        {
            double x, y;
            System.Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine()); 
            if (x >= -1 && x <= 1 && y >= -1 && y <= 1 && Math.Abs(x) + Math.Abs(y) <= 1) {
            Console.WriteLine("Точка принадлежит области ромба");
            } else {
            Console.WriteLine("Точка не принадлежит области ромба");
            }
        }
    }
}
