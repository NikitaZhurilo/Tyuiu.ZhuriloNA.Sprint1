using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZhuriloNA.Sprint1.Task7.V25.Lib
{
    public class DataService : ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Exp(x) - ((y * y + 6 + Math.Cos(x * x * x) + x * y - 2 * x * x) / (Math.Sin(x * x * x * x + 13) + 9 * y - 2)), 3);
        }
    }
}
