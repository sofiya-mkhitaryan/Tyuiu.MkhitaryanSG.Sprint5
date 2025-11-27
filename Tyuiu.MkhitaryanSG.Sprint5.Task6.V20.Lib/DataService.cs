using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на слова, учитывая пробелы и знаки препинания
                    string[] words = line.Split(new char[] { ' ', '\t', '.', ',', '!', '?', ';', ':', '-', '\"', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        if (word.Length == 6)
                            count++;
                    }
                }
            }

            return count;
        }
    }
}
