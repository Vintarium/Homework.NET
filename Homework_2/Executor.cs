using System;

namespace Homework_2
{
    public class Executor
    {
        private readonly UserService _userService;
        private readonly UserServiceAsync _userServiceAsync;

        public Executor()
        {
            _userService = new UserService();
            _userServiceAsync = new UserServiceAsync();
        }
        public async Task<string> Run(string data, bool useAsyncMethod)
        {
            string result;

            if (useAsyncMethod)
            {
                Console.WriteLine("Async method has started");
                result = await _userServiceAsync.ProcessDataAsync(data);
            }
            else
            {
                Console.WriteLine("Default method has started");
                result = _userService.ProcessData(data);
            }
            return result;
        }
    }
}
