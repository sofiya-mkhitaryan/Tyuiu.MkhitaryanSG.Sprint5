using Tyuiu.MkhitaryanSG.Sprint5.Task5.V19.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint5.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);


            DataService ds = new DataService();
            double expected = 15;
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
