using Tyuiu.AntonovNS.Sprint4.Task6.V29.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = {"Весна", "Лето", "Осень", "Зима"};
            int wait = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}