using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using static System.Console;
using System.Threading.Tasks;

namespace AsyncMethods
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            await test.Method2();
            await test.Method1();
            // Method2 - 00:00:01.0147339
            // Method1 - 00:00:02.0088333

            WriteLine("start");
            var len = GetPageLength();
            WriteLine("after");
            WriteLine(len.Result);
            WriteLine("end");

        }

        private static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apress.com");
            WriteLine("doing other job");

            return httpTask.ContinueWith((Task<HttpResponseMessage>
            antecedent) => antecedent.Result.Content.Headers.ContentLength);
        }
    }
}
