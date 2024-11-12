using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AntonovNS.Sprint4.Task5.V19.Lib
{
    public class DataService : ISprint4Task5V19
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            for (int i = 0; i <= 5 - 1; i++)
            {
                for (int j = 0; j <= 5 - 1; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        res += 1;
                    }
                }
            }
            return res;
        }
    }
}
