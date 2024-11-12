using Tyuiu.AntonovNS.Sprint4.Task5.V19.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] {{-2, -1, 0, 1, 2 },
            { 3, 1, 2, 3, 1 },
            { 1, 2, 3, 1, 2},
            { 3, 3, 1, 2, 2},
            {1, 1, 3, 2, 2} };
            int wait = 23;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}