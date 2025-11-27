using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            // Читаем содержимое файла
            string content = File.ReadAllText(path);

            // Удаляем все цифры из содержимого
            string result = Regex.Replace(content, @"d", "");

            // Удаляем лишние пробелы (заменяем несколько пробелов на один)
            result = Regex.Replace(result, @"s+", " ").Trim();

            // Сохраняем файл во временной директории
            string tempDirectory = Path.GetTempPath();
            string newFileName = "OutPutDataFileTask7V1.txt";
            string newPath = Path.Combine(tempDirectory, newFileName);

            // Записываем результат в новый файл
            File.WriteAllText(newPath, result);

            return newPath;  // Возвращаем путь к новому файлу
        }
    }
}
