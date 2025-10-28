using Tyuiu.KovalenkoMA.Sprint3.Task6.V29.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startv = 12;
            int stopv = 18;
            var res = ds.GetSumTheDivisors(startv, stopv);
            Assert.AreEqual(res, 178 );
        }
    }
}
