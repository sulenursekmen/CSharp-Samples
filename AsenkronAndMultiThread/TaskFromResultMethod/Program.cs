using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskFromResultMethod
{

    public class Program
    {
        public static string CacheData { get; set; }
        private static async Task Main(string[] args)
        {
            CacheData = await GetDataAsync();
            Console.WriteLine(CacheData);

            Console.ReadLine();
        }

        public static Task<string> GetDataAsync()
        {
            if (String.IsNullOrEmpty(CacheData))
            {
                 return File.ReadAllTextAsync("taskformresult.txt");
            }
            else
            {
                return Task.FromResult<string>(CacheData);
            }
        }
    }
}
