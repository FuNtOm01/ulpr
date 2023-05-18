using System;
public class Program {
    public static void Main() 
    {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine()); // считываем год
        for (int month = 1; month <= 12; month++) { // перебираем все месяцы года
            DateTime date = new DateTime(year, month, 1); // создаем объект даты первого дня месяца
            int daysInMonth = DateTime.DaysInMonth(year, month); // определяем количество дней в месяце
            for (int day = daysInMonth; day >= 1; day--) { // перебираем все дни месяца с конца
                if (date.AddDays(day - 1).DayOfWeek == DayOfWeek.Thursday) { // если день - последний четверг месяца
                    Console.WriteLine("{0} {1} {2}", day, date.ToString("MMMM"), year); // выводим название числа, месяца и года
                    break; // переходим к следующему месяцу
                }
            }
        }
    }
}
