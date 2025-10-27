using Tyuiu.KovalenkoMA.Sprint3.Task1.V3.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 10;
            var res = ds.GetMultiplySeries(x, y);
            Assert.AreEqual(res, 24589.408);
        }
    }
}