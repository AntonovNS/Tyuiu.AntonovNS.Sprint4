using Tyuiu.AntonovNS.Sprint4.Task7.V3.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "27182818";
            int[,] array = new int[4, 2];
            int res = ds.Calculate(4, 2, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}