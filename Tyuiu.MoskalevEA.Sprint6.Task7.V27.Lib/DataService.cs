using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevEA.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string filedata = File.ReadAllText(path);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            for (int i = 0; i < columns; i++)
            {
                if (array[4, i] < 0)
                {
                    array[4, i] = -1;
                }
            }
            return array;
        }
    }
}