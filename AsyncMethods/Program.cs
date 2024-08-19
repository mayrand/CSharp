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
        private static void Main(string[] args)
        {
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
