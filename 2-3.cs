using System;
namespace ulpr2
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите число элементов массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int max = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(100);
                Console.Write("{0} ", arr[i]);
                if (arr[i] > arr[max])
                    max = i;
            }
            System.Console.WriteLine("\nМаксимальный элемент массива под номером [{0}] = {1}.", max, arr[max]);
        }
    }
}
