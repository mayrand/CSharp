using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace Anonimowe_obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            var fura = new { marka = "BMW", model = "320i", km = 230 };
            //fura.marka = "Audi"; error wszystkie pola są read-only
            var mojaFurea = new { marka = "Honda", model = "Civic", km = 91 };
            Console.WriteLine(fura.ToString());
            SkądJestem(fura);
            SkądJestem(mojaFurea);
            Console.WriteLine(fura.Equals(mojaFurea));
            Console.Read();

        }
        public static void SkądJestem( object obj)
        {
            Console.WriteLine("{0} jest stąd:\n->{1}\nHashCode:{2}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()),obj.GetHashCode());
        }
    }
}
