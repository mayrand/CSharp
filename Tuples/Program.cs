using System;

namespace Tuples
{
    class Program
    {
        static (string, int, char) GetBob() => ("Bob", 23, 'M');
        static void Main()
        {
            //creating tuple
            var bob = (name: "Bob", age: 23, sex: 'm');
            Console.WriteLine(bob.name); // Bob
            Console.WriteLine(bob.age); // 23
            Console.WriteLine(bob.sex); // M
            //decontructing tuple
            var (name, age, sex) = bob; //or (string name,int age,char sex) = GetBob();
            Console.WriteLine(name); // Bob
            Console.WriteLine(age); // 23
            Console.WriteLine(sex); // M

        }
    }
}
