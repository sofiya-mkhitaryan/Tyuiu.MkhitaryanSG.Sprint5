using Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]

        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}
