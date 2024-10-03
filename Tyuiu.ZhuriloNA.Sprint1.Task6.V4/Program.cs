using Tyuiu.ZhuriloNA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task6.V4
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
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #4                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,        *");
            Console.WriteLine("* содержащие удвоенное н                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string value;
            Console.WriteLine("Введите строку: ");
            value = Convert.ToString(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Количество слов с удвоенной н = {ds.CheckDoubleN(value)}");
            Console.ReadKey();
        }
    }
}
