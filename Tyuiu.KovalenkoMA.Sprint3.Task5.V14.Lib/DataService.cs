using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovalenkoMA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            int i, k;
            double ss = 0;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    ss += Math.Sin(x) + 2 / k;
                }
            }
            return Math.Round(ss, 3);
        }
    }
}
