using Tyuiu.ZhuriloNA.Sprint1.Task2.V4.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int res = ds.CalculateSquare(x);
            Assert.AreEqual(4, res);
        }
    }
}