using Tyuiu.AntonovNS.Sprint4.Task1.V21.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int wait = 50;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}