using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string result = Regex.Replace(content, "\\d", "");
            result = Regex.Replace(result, "\\s+", " ").Trim();
            result = Regex.Replace(result, "\\s+([.,;:!?\\)])", "$1");
            result = Regex.Replace(result, "[.,;:!?\\)]+$", "");

            string tempDirectory = Path.GetTempPath();
            string newFileName = "OutPutDataFileTask7V1.txt";
            string newPath = Path.Combine(tempDirectory, newFileName);

            File.WriteAllText(newPath, result);

            return newPath;
        }
    }
}
