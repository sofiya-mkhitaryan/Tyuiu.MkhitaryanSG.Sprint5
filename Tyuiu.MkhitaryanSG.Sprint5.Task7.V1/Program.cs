//Удалить все цифры из файла.
using Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | Выполнила: Мхитарян С.Г. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Мхитарян София Геворковна | РППб25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все цифры из файла.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string directory = Path.Combine("C:", "DataSprint5");
            string path = Path.Combine(directory, "InPutDataFileTask7V1.txt");
            string temp = Path.GetTempPath(); string save = "OutPutDataFileTask7V1.txt";
            string savepath = Path.Combine(temp, save);

            Console.WriteLine("Данные находятся в: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string outputFilePath = ds.LoadDataAndSave(path);
                Console.WriteLine("Данные сохранены в: " + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}