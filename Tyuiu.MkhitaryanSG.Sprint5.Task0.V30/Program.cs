//Для составления пути используйте Path.Combine() (не слеши)
//Директорию берите через Path.GetTempPath()

//Или, чтобы не составлять путь можно использовать 
//Path.GetTempFileName(), он сразу создает файл с случайным именем в темп папке
//(Math.Pow(x, 2) + 1) / (3 * x + 4)
//Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt
//и вывести на консоль. Округлить до трёх знаков после запятой.
using Tyuiu.MkhitaryanSG.Sprint5.Task0.V30.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint5.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | Выполнила: Мхитарян С.Г. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Мхитарян София Геворковна | РППб25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
