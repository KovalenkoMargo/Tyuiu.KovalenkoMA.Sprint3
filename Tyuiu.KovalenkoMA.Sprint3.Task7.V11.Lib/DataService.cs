using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovalenkoMA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = stopValue - startValue + 1;
            mass = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if  ((2 - 2 * x) == 0)
                {
                    y = 0;
                    count++;
                }
                else
                {
                    y = (Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x);
                    mass[count] = Math.Round(y,2);
                    count++;
                }
                    
            }
            return mass;
        }
    }
}
