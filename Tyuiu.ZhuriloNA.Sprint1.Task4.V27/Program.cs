using Tyuiu.ZhuriloNA.Sprint1.Task4.V27.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task4.V27
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #8                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double x, y;
            Console.WriteLine("Введите первое значение : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе значение : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Результат = {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}
