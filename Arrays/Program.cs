using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MinValue;
            a--;
            Console.WriteLine(a == int.MaxValue); // True
            a++;
            {
                int x = 'x';
                Console.WriteLine(x); // True
            }
        }
    }
}
