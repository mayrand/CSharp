using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new SubClass<object, object>();
            a.DoSmthg<string>();
        }
    }

    public abstract class MyClass<T,O> where T: MyClass<T,O>
    {
        public MyClass()
        {
            Console.WriteLine($"Base: {typeof(T)}");
        }

        public abstract void DoSmthg<U>() where U : O;
    }

    class SubClass<T,O> : MyClass<SubClass<T,O>,O>
    {
        public SubClass()
        {
            Console.WriteLine(typeof(T));
        }

        public override void DoSmthg<O>() 
        {
            Console.WriteLine(typeof(O));
        }
    }
}
