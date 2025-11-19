using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });                                                            //$@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x - 1 == 0)
                {
                    y = 0;
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = Math.Round((((Math.Sin(x) - 2 * x) / (3 * x - 1)) + Math.Sin(x) - (3 * x) + 2), 2);
                    strY = Convert.ToString(y);
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
