using Tyuiu.ZhuriloNA.Sprint1.Task7.V25.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2.098, res);
        }
    }
}