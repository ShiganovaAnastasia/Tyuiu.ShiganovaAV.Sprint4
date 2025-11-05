using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShiganovaAV.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, 1];
            }
            return sum;
        }
    }
}
