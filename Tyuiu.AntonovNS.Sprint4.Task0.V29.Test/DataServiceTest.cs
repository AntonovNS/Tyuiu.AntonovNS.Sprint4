using Tyuiu.AntonovNS.Sprint4.Task0.V29.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int wait = 32;
            int res = ds.GetSumOddArrEl(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}