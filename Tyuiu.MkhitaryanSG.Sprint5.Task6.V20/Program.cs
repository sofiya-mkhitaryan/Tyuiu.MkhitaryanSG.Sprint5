//Найти количество слов длиной шесть символов в заданной строке.
using Tyuiu.MkhitaryanSG.Sprint5.Task6.V20.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint5.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | Выполнила: Мхитарян С.Г. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Мхитарян София Геворковна | РППб25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество слов длиной шесть символов в заданной строке.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string directory = Path.Combine("C:", "DataSprint5");
            string path = Path.Combine(directory, "InPutDataFileTask6V20.txt");

            Console.WriteLine("Данные находятся в файле:" + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}