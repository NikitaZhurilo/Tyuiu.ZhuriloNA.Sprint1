using Tyuiu.ZhuriloNA.Sprint1.Task1.V28.Lib;

namespace Tyuiu.ZhuriloNA.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 1.6);
        }
    }
}