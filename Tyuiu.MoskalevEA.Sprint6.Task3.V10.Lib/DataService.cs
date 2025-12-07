using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MoskalevEA.Sprint6.Task3.V10.Lib
{
    public class DataService : ISprint6Task3V10
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows >= 5)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[4, j] % 2 == 0)
                    {
                        matrix[4, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}