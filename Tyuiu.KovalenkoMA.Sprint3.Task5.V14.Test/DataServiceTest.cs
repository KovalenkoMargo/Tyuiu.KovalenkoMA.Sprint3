using Tyuiu.KovalenkoMA.Sprint3.Task5.V14.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startv1 = 1;
            int startv2 = 1;
            int stopv1 = 14;
            int stopv2 = 3;
            int x = 5;
            var res = ds.GetSumSumSeries(x, startv1, startv2, stopv1, stopv2);
            Assert.AreEqual(res, -31.275);
        }
    }
}
