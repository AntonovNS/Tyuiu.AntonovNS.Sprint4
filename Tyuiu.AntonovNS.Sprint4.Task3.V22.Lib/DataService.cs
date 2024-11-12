using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AntonovNS.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i <= 5 - 1; i++)
            {
                for (int j = 0; i <= 5 - 1; i++) 
                {
                    if (j == 0 && res < array[i, j]) 
                    {
                        res = array[i, j]; 
                    }
                }
            }
            return res;
    }
    }
}
