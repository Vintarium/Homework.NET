using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_2;
using System.Threading.Tasks; 

namespace Homework_2
{
    [TestClass]
    public class UserServiceAsyncTests
    {
        [TestMethod]
        public async Task ProcessDataAsync_WhenCalled_ReturnsCorrectString()
        {
           
            var service = new UserServiceAsync();
            string dataName = "MyDataFile";
            string expected = "Обработка 'MyDataFile' завершена за 3 секунды";

          
            string actual = await service.ProcessDataAsync(dataName);

          
            Assert.AreEqual(expected, actual);
        }
    }
}