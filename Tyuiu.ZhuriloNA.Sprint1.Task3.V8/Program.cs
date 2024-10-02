using Tyuiu.ZhuriloNA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #8                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double startAmount, percent, timeDays;
            Console.WriteLine("Введите величину вклада : ");
            startAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент вклада : ");
            percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите срок вклада : ");
            timeDays = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Доход от вклада = {ds.IncomeAmount(startAmount, percent, timeDays)}");
            Console.ReadKey();
        }
    }
}
