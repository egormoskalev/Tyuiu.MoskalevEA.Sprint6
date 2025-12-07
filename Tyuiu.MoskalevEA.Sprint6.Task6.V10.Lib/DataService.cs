using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MoskalevEA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("w"))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            string[] FinalResult = resStr.Split(' ');
            resStr = "";
            for (int i = 0; i < FinalResult.Length; i++)
            {
                if (FinalResult[i].Contains("w"))
                {
                    if (resStr == "")
                    {
                        resStr = FinalResult[i];
                    }
                    else
                    {
                        resStr = resStr + " " + FinalResult[i];
                    }
                }
            }
            return resStr;
        }
    }
}