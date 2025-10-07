using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_2;

namespace Homework_2
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void ProcessData_WhenCalled_ReturnsCorrectString()
        {
           
            var service = new UserService();
            string dataName = "SimpleFile";
            string expected = "Обработка 'SimpleFile' завершена за 3 секунды";

            string actual = service.ProcessData(dataName);

            Assert.AreEqual(expected, actual);
        }
    }
}