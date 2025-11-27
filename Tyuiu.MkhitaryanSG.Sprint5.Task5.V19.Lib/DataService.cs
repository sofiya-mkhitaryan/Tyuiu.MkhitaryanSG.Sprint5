using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            int? min = null;
            int? max = null;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] chisla = line.Split(' ');

                    foreach (var chislo in chisla)
                    {
                        if (int.TryParse(chislo, out int temp) && temp >= -9 && temp <= 9)
                        {
                            if (min == null || temp < min)
                                min = temp;
                            if (max == null || temp > max)
                                max = temp;
                        }
                    }
                }
            }

            if (min.HasValue && max.HasValue)
            {
                return Math.Round((double)(max.Value - min.Value), 3);
            }

            return 0; // Возвращает 0, если однозначные числа не найдены
        }
    }
}
