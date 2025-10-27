using Tyuiu.KovalenkoMA.Sprint3.Task4.V18.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task4.V18.Test
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
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(res, 2.993);
        }
    }
}
