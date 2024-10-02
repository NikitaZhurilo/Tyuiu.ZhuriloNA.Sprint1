using Tyuiu.ZhuriloNA.Sprint1.Task0.V28.Lib;

namespace Tyuiu.ZhuriloNA.Sprint1.Task0.V28
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
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #28                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 48/12-48/6/4                *");
            Console.WriteLine("* и печатает результат на экране.                                             *");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* 48/12-48/6/4                                                                *");
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
