using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncMethods;

public class test
{
    public static async Task Method1() 
    {
        var sw = Stopwatch.StartNew();
        await Task.Delay(TimeSpan.FromSeconds(1));
        await Task.Delay(TimeSpan.FromSeconds(1));
        sw.Stop();
        Console.WriteLine("Method1 - {0}", sw.Elapsed);
    }
    public static async Task Method2() 
    {
        var sw = Stopwatch.StartNew();
        var t1 = Task.Delay(TimeSpan.FromSeconds(1));
        var t2 = Task.Delay(TimeSpan.FromSeconds(1));
        await t1;
        await t2;
        sw.Stop();
        Console.WriteLine("Method2 - {0}", sw.Elapsed);
    }
}