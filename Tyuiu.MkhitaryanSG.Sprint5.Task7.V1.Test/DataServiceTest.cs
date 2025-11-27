using Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private string GetTestFilePath()
        {
            string dir = Path.Combine("C:", "DataSprint5");
            string path = Path.Combine(dir, "InPutDataFileTask7V1.txt");
            return path;
        }

        [TestMethod]
        public void TestMethod1()
        {
            string testFilePath = GetTestFilePath();

            string input = "123 Привет, это тестовая строка 456.";
            File.WriteAllText(testFilePath, input);

            var service = new DataService();
            string output = service.LoadDataAndSave(testFilePath);

            string expected = " Привет, это тестовая строка .";

            Assert.AreEqual(expected, output);
            Assert.AreEqual(expected, File.ReadAllText(testFilePath));
        }
    }
}
