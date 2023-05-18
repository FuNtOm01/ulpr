using System;
namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            int n = int.Parse(Console.ReadLine()); //получаем число n от пользователя
            Random random = new Random(); //создаем экземпляр класса Random для генерации случайного числа
            int randomNumber = random.Next(1, n+1); //генерируем случайное число от 1 до n
            Console.WriteLine("Компьютер загадал число от 1 до {0}.", n);
            System.Console.WriteLine("Введите кол-во попыток: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("У вас есть {0} попытки(ток), чтобы его угадать.", k);
            while (k > 0) //цикл продолжается, пока у пользователя есть попытки
            {
                Console.WriteLine("Введите вашу попытку:");
                int guess = int.Parse(Console.ReadLine()); //получаем попытку от пользователя
                if (guess == randomNumber) //если пользователь угадал число
                {
                    Console.WriteLine("Вы угадали!");
                    return; //завершаем программу
                }
                else if (guess < randomNumber) //если попытка меньше загаданного числа
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else //если попытка больше загаданного числа
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                k--; //уменьшаем количество попыток на 1
            }
            Console.WriteLine("Попытки закончились. Вы проиграли.");
        }
    }
}
