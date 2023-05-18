using System;
namespace year
{
    class programm
    {
        static void Main()
        {
            int a, b, c, k=0, days=365, x;
            int[] Monthdays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите день:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            c = Convert.ToInt32(Console.ReadLine());
            if ( (c%400 == 0) | ((c%4==0) & (c%10==0)) )
            {
            Monthdays[1] = 29;
            days = 366;
            }
            while (k == 0)
            {
            if ( (Monthdays[b-1]<a) | (a<=0 | b<=0 | c<=0) )
            {
            Console.WriteLine("Введите другую дату.");
            Console.WriteLine("Введите день:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            c = Convert.ToInt32(Console.ReadLine());
             }
            else
            {
            Console.WriteLine("Правильная дата");
            k = 1;
            }
            }
            x = a;
            for (int i = 0; i < b-1; i++)
            {
            x += Monthdays[i];
            }
            Console.WriteLine(x);
            Console.WriteLine(days-x);
        }
    }
}
