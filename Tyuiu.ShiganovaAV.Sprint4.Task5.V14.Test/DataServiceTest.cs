using Tyuiu.ShiganovaAV.Sprint4.Task5.V14.Lib;
namespace Tyuiu.ShiganovaAV.Sprint4.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
                { -3, 2, -5, 4, 1 },
                { 0, -2, 7, -1, 3 },
                { 5, -4, 6, 2, -3 },
                { 1, 7, -2, 0, 4 },
                { -1, 3, 5, -5, 2 }
            };
            int res = ds.Calculate(matrix);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
 }
