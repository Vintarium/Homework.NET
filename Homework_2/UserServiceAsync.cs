using System;

namespace Homework_2
{
    public class UserServiceAsync

    {
        public UserServiceAsync() { }
        public async Task<string> ProcessDataAsync(string dataName)
        {
            await Task.Delay(3000);
            return $"Обработка '{dataName}' завершена за 3 секунды";
        }
    }
}
