using Tyuiu.MkhitaryanSG.Sprint5.Task0.V30.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
