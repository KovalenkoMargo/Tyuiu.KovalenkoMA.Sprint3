using Tyuiu.KovalenkoMA.Sprint3.Task2.V14.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 6;
            var res = ds.GetMultiplySeries(5, x, y);
            Assert.AreEqual(res, 10220.275);
        }
    }
}
