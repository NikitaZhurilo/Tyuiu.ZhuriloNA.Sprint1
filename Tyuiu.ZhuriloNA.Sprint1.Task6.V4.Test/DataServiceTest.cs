using Tyuiu.ZhuriloNA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.ZhuriloNA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "�� ����� ���� ����� ���������� �����, �� ��������� �� ��� �������� ������������";
            string res = ds.CheckDoubleN(value);
            Assert.AreEqual(" ��������", res);
        }
    }
}