using Tyuiu.KovalenkoMA.Sprint3.Task7.V11.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] mass;
            mass = new double[len];
            mass[0] = 20.36;
            mass[1] = 15.42;
            mass[2] = 10.99;
            mass[3] = 7.43;
            mass[4] = 4.33;
            mass[5] = 1.00;
            mass[6] = 0.00;
            mass[7] = -8.87;
            mass[8] = -13.03;
            mass[9] = -16.53;
            mass[10] = -19.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}
