using Tyuiu.MkhitaryanSG.Sprint5.Task2.V7.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 9, 2, 8 },
                { 7, 1, 2 },
                { 5, 5, 1 }
            };

            string fullPath = ds.SaveToFileTextData(matrix);


            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
