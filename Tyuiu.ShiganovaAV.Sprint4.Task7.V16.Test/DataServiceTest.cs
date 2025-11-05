using Tyuiu.ShiganovaAV.Sprint4.Task7.V16.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "382976421897948";
            int n = 5;
            int m = 3;
            int res = ds.Calculate(n, m, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);
        }
    }
}
