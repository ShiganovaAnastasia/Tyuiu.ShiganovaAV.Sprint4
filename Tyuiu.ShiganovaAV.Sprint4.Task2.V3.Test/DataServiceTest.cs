using Tyuiu.ShiganovaAV.Sprint4.Task2.V3.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
