using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add("Dupa", "śnie"));
            Console.WriteLine(Add(1, "Dupa"));
            //Niedasie
            //Console.WriteLine(Add(true, false));
            //Console.WriteLine(typeof(dynamic).ToString());
        }

        static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
}
