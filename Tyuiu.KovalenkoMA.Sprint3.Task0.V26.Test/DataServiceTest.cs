using Tyuiu.KovalenkoMA.Sprint3.Task0.V26.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;
            var res = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(res, -15.642);
        }
    }
}
