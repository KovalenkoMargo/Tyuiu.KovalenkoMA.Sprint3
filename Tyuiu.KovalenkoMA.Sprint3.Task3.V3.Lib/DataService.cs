using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovalenkoMA.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int mincount = int.MaxValue;
            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    if (count < mincount && count > 1)
                    {
                        mincount = count;
                    }
                    count = 0;
                }
            }
            return mincount;
        }
    }
}