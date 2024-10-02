using Tyuiu.ZhuriloNA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double percent = 20;
            double timeDays = 30;
            double res = ds.IncomeAmount(startAmount, percent, timeDays);
            Assert.AreEqual(41.096, res);
        }
    }
}