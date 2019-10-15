using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreams
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Press any key when ready");
            Console.ReadLine();
            await foreach (var e in GetDataAsync())
            {
                Console.WriteLine(e);
            }
        }

        static IEnumerable<string> GetData()
        {
            yield return "data A";
            yield return "data B";
        }

        static async IAsyncEnumerable<string> GetDataAsync()
        {
            await Task.Delay(1500);
            yield return "data A";
            await Task.Delay(2000);
            yield return "data B";
        }
    }
}
