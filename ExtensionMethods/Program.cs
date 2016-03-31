using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                WriteLine(arg.MakePretty());
            }
        }
    }

    public static class MyExtensionMethods
    {
        public static string MakePretty(this string text)
        {
            return $"-={text}=-";
        }
    }
}
