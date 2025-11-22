//Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.
//9; 2; 8
//7; 1; 2
//5; 5; 1
using Tyuiu.MkhitaryanSG.Sprint5.Task2.V7.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint5.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | Выполнила: Мхитарян С.Г. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Мхитарян София Геворковна | РППб25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить нечетные элементы         *");
            Console.WriteLine("* массива на 0. Результат                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[3, 3] { { 9,2,8 },
                                            { 7,1,2 },
                                            { 5,5,1 } };
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;
            Console.WriteLine("Массив");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
