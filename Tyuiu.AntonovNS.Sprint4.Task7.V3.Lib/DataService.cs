using System.Data.Common;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AntonovNS.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    res[i,j] = int.Parse(value.Substring(i * m + j,1));
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (res[i,j]%2!=0) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
