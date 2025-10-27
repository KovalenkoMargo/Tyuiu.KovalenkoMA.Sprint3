using Tyuiu.KovalenkoMA.Sprint3.Task3.V3.Lib;
namespace Tyuiu.KovalenkoMA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            var res = ds.GetMinCharCount(value, item);
            Assert.AreEqual(res, 2);
        }
    }
}