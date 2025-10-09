using System;

namespace Homework_2
{
    public class UserService
    {
        public UserService() { }

        public string ProcessData(string dataName)
        {
            Thread.Sleep(3000);
            return $"Обработка '{dataName}' завершена за 3 секунды";
        }
    }
}
