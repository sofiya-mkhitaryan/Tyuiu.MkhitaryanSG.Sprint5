using Tyuiu.MkhitaryanSG.Sprint5.Task1.V11.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
