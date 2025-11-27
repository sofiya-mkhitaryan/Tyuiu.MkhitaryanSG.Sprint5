using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            FileInfo fileInfo = new FileInfo(path);
            strX = strX.Replace(".", ",");
            if (fileInfo.Exists)
            {
                double x = Convert.ToDouble(strX);
                double res = Math.Round(Math.Sin(Convert.ToDouble(x)) + (Math.Pow(Convert.ToDouble(x), 2) / 2), 3);
                return res;
            }
            else
            {
                double res = 0;
                return res;
            }
        }
    }
}
