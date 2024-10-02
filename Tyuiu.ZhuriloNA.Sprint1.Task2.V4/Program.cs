using Tyuiu.ZhuriloNA.Sprint1.Task2.V4.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task2.V4
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
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int x;
            Console.WriteLine("Введите длину стороны квадрата : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Площадь квадрата = {ds.CalculateSquare(x)}");
            Console.ReadKey();
        }
    }
}
