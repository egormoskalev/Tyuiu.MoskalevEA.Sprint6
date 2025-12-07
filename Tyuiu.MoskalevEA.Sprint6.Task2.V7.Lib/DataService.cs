using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                resultArray[i] = CalculateFunction(x);
            }

            return resultArray;
        }
        private double CalculateFunction(int x)
        {
            double cosX = Math.Cos(x);
            double denominator = cosX + 1;

            if (Math.Abs(denominator) < 0.0000001)
            {
                return 0; 
            }

            double numerator = (2 * x) - x;
            double fraction = numerator / denominator;
            double result = (3 * x) + 2 - fraction;

            return Math.Round(result, 2);
        }
    }
}