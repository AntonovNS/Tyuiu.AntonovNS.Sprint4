using Tyuiu.AntonovNS.Sprint4.Task3.V22.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { { 4, 4, 7, 8, 9 }, 
                { 9, 5, 9, 7, 8 }, 
                { 7, 4, 9, 4, 6 }, 
                { 4, 4, 7, 4, 4 }, 
                { 4, 5, 8, 6, 7 } };
            int wait = 9;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}