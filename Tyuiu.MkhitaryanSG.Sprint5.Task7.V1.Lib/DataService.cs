using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string result = Regex.Replace(content, @"\d", "");

            File.WriteAllText(path, result);

            return result;
        }
    }
}
