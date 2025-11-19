using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(directory, fileName);

            double z = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            z = Math.Round(z, 3);

            File.WriteAllText(fullPath, Convert.ToString(z));
            return fullPath;
        }
    }
}
