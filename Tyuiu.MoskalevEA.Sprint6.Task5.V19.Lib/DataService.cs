using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YakimukVV.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);
                var result = new List<double>();

                foreach (var line in lines)
                {
                    if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                    {
                        if (number % 1 == 0)
                        {
                            result.Add(number);
                        }
                        else
                        {
                            result.Add(Math.Round(number, 3));
                        }
                    }
                }

                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке данных из файла: {ex.Message}");
            }
        }
    }
}
