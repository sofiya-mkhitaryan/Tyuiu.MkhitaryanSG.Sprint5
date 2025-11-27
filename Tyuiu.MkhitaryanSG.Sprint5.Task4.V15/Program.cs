//Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту.
//Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть вещественное значение.
//Прочитать значение из файла и подставить вместо Х в формуле
//Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и 
//вернуть полученный результат на консоль.
using Tyuiu.MkhitaryanSG.Sprint5.Task4.V15.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint5.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | Выполнила: Мхитарян С.Г. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Мхитарян София Геворковна | РППб25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение по формуле.                       *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
