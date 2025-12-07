using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevEA.Sprint6.Task1.V24.Lib
{
    public class DataService : ISprint6Task1V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1.7)
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round(Math.Sin(x) / (x + 1.7) - Math.Cos(x) * (4 * x) - 6, 2);
                k++;
            }
            return mass;
        }
    }
}