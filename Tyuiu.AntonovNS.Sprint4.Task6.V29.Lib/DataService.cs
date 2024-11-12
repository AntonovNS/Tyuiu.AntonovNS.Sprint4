using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AntonovNS.Sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            for (int i = 0; i < 4; i++) 
            {
                if (array[i].Length > 4) 
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
