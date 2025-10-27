using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovalenkoMA.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int x, int y)
        {
            double res = 1;
            while (x <= y)
            {
                res *= x / (Math.Pow((Math.Cos(5) + 1), 2));
                x++;
            }
            return Math.Round(res, 3);
        }
    }
}