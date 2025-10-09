using System;
using System.Diagnostics;

namespace Homework_2
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch swForAsyncMethod = Stopwatch.StartNew();
            Stopwatch swForDefaultMethod = Stopwatch.StartNew();

            Executor executor = new Executor();

            swForAsyncMethod.Start();
            var task1 = executor.Run("File 1", true);
            var task2 = executor.Run("File 2", true);
            var task3 = executor.Run("File 3", true);
            var results = await Task.WhenAll(task1, task2, task3);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            swForAsyncMethod.Stop();
            Console.WriteLine($"Async method running time: {swForAsyncMethod.Elapsed.Seconds} seconds ");

            swForDefaultMethod.Start();
            Console.WriteLine(executor.Run("File1", false).Result);
            Console.WriteLine(executor.Run("File2", false).Result);
            Console.WriteLine(executor.Run("File3", false).Result);
            swForDefaultMethod.Stop();
            Console.WriteLine($"Default method running time: {swForDefaultMethod.Elapsed.Seconds} seconds ");
        }
    }
}
