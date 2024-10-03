using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZhuriloNA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            int startIndex = 0;
            int length = 1;

            string res = "";
            string input = value;
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    res = res + " " + word;
                }
                
            }
            res = res.Remove(startIndex, length);
            return res;
        }
    }
}

